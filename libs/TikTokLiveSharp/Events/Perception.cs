using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class Perception : AMessageData
    {
        public readonly PerceptionDialogInfo Dialog;
        public readonly PunishEventInfo PunishInfo;
        public readonly long EndTime;
        public readonly bool ShowViolationWarning;
        public readonly Text Toast;
        public readonly int FloatStyle;
        public readonly Text FloatText;

        internal Perception(Models.Protobuf.Messages.PerceptionMessage msg)
            : base(msg?.Header)
        {
            Dialog = msg?.Dialog;
            PunishInfo = msg?.PunishInfo;
            EndTime = msg?.EndTime ?? -1;
            ShowViolationWarning = msg?.ShowViolationWarning ?? false;
            Toast = msg?.Toast;
            FloatStyle = msg?.FloatStyle ?? -1;
            FloatText = msg?.FloatText;
        }
    }
}