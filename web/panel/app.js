// TikControl Caosbloxer - Panel web (base)
// Los eventos llegan desde la app nativa a traves de window.tikControl.onEvent.

(function () {
  "use strict";

  var list = document.getElementById("eventList");
  var statD = document.getElementById("statDiamonds");
  var statF = document.getElementById("statFollowers");
  var statC = document.getElementById("statComments");
  var overlayToggle = document.getElementById("overlayToggle");
  var soundToggle = document.getElementById("soundToggle");
  var liveStatus = document.getElementById("liveStatus");
  var usernameInput = document.getElementById("usernameInput");
  var btnConnect = document.getElementById("btnConnect");

  var counts = { diamonds: 0, followers: 0, comments: 0 };
  var connected = false;
  var hasBridge = !!window.chrome && !!window.chrome.webview;

  function post(msg) {
    if (hasBridge) window.chrome.webview.postMessage(msg);
  }

  // ── Conexion al LIVE real (via puente nativo) ─────
  function setConnected(on, statusText) {
    connected = on;
    btnConnect.textContent = on ? "Desconectar" : "Conectar";
    liveStatus.innerHTML = "<i class='dot'></i> " + statusText;
    liveStatus.classList.toggle("live", on);
  }

  function connect() {
    var user = (usernameInput.value || "").trim().replace(/^@/, "");
    if (!user) { usernameInput.focus(); return; }
    if (connected) { post({ type: "disconnect" }); return; }
    setConnected(true, "Conectando a @" + user + "...");
    post({ type: "connect", username: user });
  }

  btnConnect.addEventListener("click", connect);
  usernameInput.addEventListener("keydown", function (e) {
    if (e.key === "Enter") connect();
  });

  function beacon(text) {
    // Beep simple de alerta (se activa/desactiva con sonido)
    try {
      var ctx = new (window.AudioContext || window.webkitAudioContext)();
      var o = ctx.createOscillator();
      var g = ctx.createGain();
      o.connect(g); g.connect(ctx.destination);
      o.frequency.value = 880;
      g.gain.value = 0.08;
      o.start();
      g.gain.exponentialRampToValueAtTime(0.0001, ctx.currentTime + 0.18);
      o.stop(ctx.currentTime + 0.2);
    } catch (e) { /* sin audio */ }
  }

  window.tikControl = {
    onState: function (s) {
      // s: { state, username, viewers, diamonds, followers, comments }
      counts.diamonds = s.diamonds || 0;
      counts.followers = s.followers || 0;
      counts.comments = s.comments || 0;
      statD.textContent = counts.diamonds.toLocaleString("es-MX");
      statF.textContent = counts.followers.toLocaleString("es-MX");
      statC.textContent = counts.comments.toLocaleString("es-MX");

      var txt = (s.username ? "@" + s.username + " · " : "") + "en línea";
      switch (s.state) {
        case "demo": setConnected(false, "Modo DEMO"); break;
        case "connecting": setConnected(true, "Conectando a @" + (s.username || "?") + "..."); break;
        case "connected":
          setConnected(true, txt + (s.viewers ? " · 👁 " + s.viewers : ""));
          break;
        case "disconnected":
          setConnected(false, "Conexion perdida. Modo DEMO");
          break;
      }
    },

    onEvent: function (ev) {
      // ev: { kind, user, label, detail, value, emoji }
      if (ev.kind === "Gift") counts.diamonds += ev.value || 0;
      if (ev.kind === "Follow") counts.followers++;
      if (ev.kind === "Comment") counts.comments++;

      statD.textContent = counts.diamonds.toLocaleString("es-MX");
      statF.textContent = counts.followers.toLocaleString("es-MX");
      statC.textContent = counts.comments.toLocaleString("es-MX");

      var li = document.createElement("li");
      li.className = "event-item " + (ev.kind || "").toLowerCase();

      var em = document.createElement("span");
      em.className = "event-emoji";
      em.textContent = ev.emoji || "▪";

      var info = document.createElement("span");
      info.innerHTML = "<span class='event-user'></span> <span class='event-label'></span>";
      info.querySelector(".event-user").textContent = ev.user || "";
      info.querySelector(".event-label").textContent = ev.detail || ev.label || "";

      var kind = document.createElement("span");
      kind.className = "event-kind";
      kind.textContent = (ev.kind || "").toUpperCase();

      li.appendChild(em); li.appendChild(info); li.appendChild(kind);
      list.prepend(li);

      while (list.children.length > 30) list.removeChild(list.lastChild);

      if (soundToggle.checked) beacon();
      if (overlayToggle.checked) showOverlay(ev);
    }
  };

  // ── Overlay simple en pantalla (base) ─────────────
  function showOverlay(ev) {
    var box = document.createElement("div");
    box.className = "overlay-pop " + (ev.kind || "").toLowerCase();
    box.innerHTML =
      "<span class='overlay-emoji'></span>" +
      "<div><div class='overlay-user'></div><div class='overlay-label'></div></div>";
    box.querySelector(".overlay-emoji").textContent = ev.emoji || "▪";
    box.querySelector(".overlay-user").textContent = ev.user || "";
    box.querySelector(".overlay-label").textContent = (ev.label || ev.titleKind || "");

    document.body.appendChild(box);
    setTimeout(function () { box.classList.add("show"); }, 10);
    setTimeout(function () { box.classList.remove("show"); setTimeout(function () { box.remove(); }, 400); }, 2800);
  }

  document.getElementById("btnClear").addEventListener("click", function () {
    list.innerHTML = "";
  });
})();
