namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextFormat
    {
        public readonly string Color;

        public readonly bool Bold;

        public readonly bool Italic;

        public readonly int Weight;
        
        public readonly int ItalicAngle;
        
        public readonly int FontSize;
        
        public readonly bool UseHighLightColor;
        
        public readonly bool UseRemoteColor;

        private TextFormat(Models.Protobuf.Objects.TextFormat textFormat)
        {
            Color = textFormat?.Color ?? string.Empty;
            Bold = textFormat?.Bold ?? false;
            Italic = textFormat?.Italic ?? false;
            Weight = textFormat?.Weight ?? -1;
            ItalicAngle = textFormat?.ItalicAngle ?? -1;
            FontSize = textFormat?.FontSize ?? -1;
            UseHighLightColor = textFormat?.UseHeighLightColor ?? false;
            UseRemoteColor = textFormat?.UseRemoteClor ?? false;
        }

        public static implicit operator TextFormat(Models.Protobuf.Objects.TextFormat textFormat) => new TextFormat(textFormat);
    }
}