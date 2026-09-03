namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubCustomizedBenefitMedia
    {
        public Picture IconImg;
        public string Title;
        public string Content;
        public string Url;
        public string BackgroundColor;

        private SubCustomizedBenefitMedia(Models.Protobuf.Objects.SubCustomizedBenefitMedia media)
        {
            IconImg = media?.IconImg;
            Title = media?.Title ?? string.Empty;
            Content = media?.Content ?? string.Empty;
            Url = media?.Url ?? string.Empty;
            BackgroundColor = media?.BackgroundColor ?? string.Empty;
        }

        public static implicit operator SubCustomizedBenefitMedia(Models.Protobuf.Objects.SubCustomizedBenefitMedia media) => new SubCustomizedBenefitMedia(media);
    }
}
