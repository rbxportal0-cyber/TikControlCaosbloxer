namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftBanner
    {
        public readonly Text DisplayText;
        public readonly string DisplayTextBgColor;
        public readonly Picture BoxImg;
        public readonly Picture BgImg;
        public readonly string SchemeUrl;
        public readonly bool Animate;

        private GiftBanner(Models.Protobuf.Objects.GiftBanner banner)
        {
            DisplayText = banner?.DisplayText;
            DisplayTextBgColor = banner?.DisplayTextBgColor ?? string.Empty;
            BoxImg = banner?.BoxImg;
            BgImg = banner?.BgImg;
            SchemeUrl = banner?.SchemeUrl;
            Animate = banner?.Animate ?? false;
        }

        public static implicit operator GiftBanner(Models.Protobuf.Objects.GiftBanner banner) => new GiftBanner(banner);
    }
}
