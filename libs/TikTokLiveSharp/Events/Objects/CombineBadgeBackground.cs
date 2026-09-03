namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CombineBadgeBackground
    {
        public readonly Picture Image;
        public readonly string BackgroundColorCode;
        public readonly string BorderColorCode;

        private CombineBadgeBackground(Models.Protobuf.Objects.CombineBadgeBackground bg)
        {
            Image = bg?.Image;
            BackgroundColorCode = bg?.BackgroundColorCode ?? string.Empty;
            BorderColorCode = bg?.BorderColorCode ?? string.Empty;
        }

        public static implicit operator CombineBadgeBackground(Models.Protobuf.Objects.CombineBadgeBackground bg) => new CombineBadgeBackground(bg);
    }
}
