namespace TikControl.Core;

/// <summary>Tipo de evento entrante del LIVE de TikTok.</summary>
public enum TikTokEventKind
{
    Gift,
    Follow,
    Comment
}

/// <summary>Evento normalizado que la interfaz consume (independiente del conector).</summary>
public sealed class TikTokEvent
{
    public TikTokEventKind Kind { get; init; }
    public string User { get; init; } = "";
    public string Label { get; init; } = "";
    public string Detail { get; init; } = "";
    public int Value { get; init; }
    public DateTimeOffset At { get; init; } = DateTimeOffset.Now;

    public string Emoji => Kind switch
    {
        TikTokEventKind.Gift => "🎁",
        TikTokEventKind.Follow => "➕",
        TikTokEventKind.Comment => "💬",
        _ => "▪"
    };

    public string TitleKind => Kind switch
    {
        TikTokEventKind.Gift => "REGALO",
        TikTokEventKind.Follow => "NUEVO SEGUIDOR",
        TikTokEventKind.Comment => "COMENTARIO",
        _ => "EVENTO"
    };
}
