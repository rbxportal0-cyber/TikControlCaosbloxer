namespace TikTokLiveSharp.Events.Objects
{
    public sealed class FontStyle
    {
        public readonly int FontSize;
        public readonly int FontWidth;
        public readonly string FontColor;
        public readonly string BorderColor;

        private FontStyle(Models.Protobuf.Objects.FontStyle fontStyle)
        {
            FontSize = fontStyle?.FontSize ?? -1;
            FontWidth = fontStyle?.FontWidth ?? -1;
            FontColor = fontStyle?.FontColor ?? string.Empty;
            BorderColor = fontStyle?.BorderColor ?? string.Empty;
        }

        public static implicit operator FontStyle(Models.Protobuf.Objects.FontStyle fontStyle) => new FontStyle(fontStyle);
    }
}
