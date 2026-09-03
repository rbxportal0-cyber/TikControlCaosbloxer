namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftPanelOperation
    {
        public readonly Picture LeftImage;
        public readonly Picture RightImage;
        public readonly string Title;
        public readonly string TitleColor;
        public readonly long TitleSize;
        public readonly string SchemeUrl;
        public readonly string EventName;

        private GiftPanelOperation(Models.Protobuf.Objects.GiftPanelOperation operation)
        {
            LeftImage = operation?.LeftImage;
            RightImage = operation?.RightImage;
            Title = operation?.Title ?? string.Empty;
            TitleColor = operation?.TitleColor ?? string.Empty;
            TitleSize = operation?.TitleSize ?? -1;
            SchemeUrl = operation?.SchemeUrl ?? string.Empty;
            EventName = operation?.EventName ?? string.Empty;
        }

        public static implicit operator GiftPanelOperation(Models.Protobuf.Objects.GiftPanelOperation operation) => new GiftPanelOperation(operation);
    }
}
