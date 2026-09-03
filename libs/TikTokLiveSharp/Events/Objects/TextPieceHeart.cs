namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextPieceHeart
    {
        public readonly string Color;

        private TextPieceHeart(Models.Protobuf.Objects.TextPieceHeart heart)
        {
            Color = heart?.Color ?? string.Empty;
        }

        public static implicit operator TextPieceHeart(Models.Protobuf.Objects.TextPieceHeart heart) => new TextPieceHeart(heart);
    }
}