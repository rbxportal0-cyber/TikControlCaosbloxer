namespace TikTokLiveSharp.Events.Objects
{
    public sealed class HourlyRankSlidePage
    {
        public readonly long Duration;
        public readonly Text Content;
        public readonly string BackgroundColor;
        public readonly string SchemeLink;

        private HourlyRankSlidePage(Models.Protobuf.Objects.HourlyRankSlidePage slidePage)
        {
            Duration = slidePage?.Duration ?? -1;
            Content = slidePage?.Content;
            BackgroundColor = slidePage?.BackgroundColor ?? string.Empty;
            SchemeLink = slidePage?.SchemeLink ?? string.Empty;
        }

        public static implicit operator HourlyRankSlidePage(Models.Protobuf.Objects.HourlyRankSlidePage slidePage) => new HourlyRankSlidePage(slidePage);
    }
}
