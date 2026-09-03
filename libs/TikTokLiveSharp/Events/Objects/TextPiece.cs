namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextPiece
    {
        public readonly int Type;

        public readonly TextFormat Format;

        public readonly string StringValue;

        public readonly TextPieceUser UserValue;

        public readonly TextPieceGift GiftValue;

        public readonly TextPieceHeart HeartValue;

        public readonly PatternRef PatternRefValue;

        public readonly TextPieceImage ImageValue;

        private TextPiece(Models.Protobuf.Objects.TextPiece textPiece)
        {
            Type = textPiece?.Type ?? -1;
            Format = textPiece?.Format;
            StringValue = textPiece?.StringValue ?? string.Empty;
            UserValue = textPiece?.UserValue;
            GiftValue = textPiece?.GiftValue;
            HeartValue = textPiece?.HeartValue;
            PatternRefValue = textPiece?.PatternRefValue;
            ImageValue = textPiece?.ImageValue;
        }

        public static implicit operator TextPiece(Models.Protobuf.Objects.TextPiece textPiece) => new TextPiece(textPiece);
    }
}