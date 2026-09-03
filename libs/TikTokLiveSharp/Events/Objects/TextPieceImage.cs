namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextPieceImage
    {
        public readonly Picture Image;

        private TextPieceImage(Models.Protobuf.Objects.TextPieceImage image)
        {
            Image = image?.Image;
        }

        public static implicit operator TextPieceImage(Models.Protobuf.Objects.TextPieceImage image) => new TextPieceImage(image);
    }
}