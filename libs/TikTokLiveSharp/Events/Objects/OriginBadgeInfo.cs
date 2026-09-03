namespace TikTokLiveSharp.Events.Objects
{
    public sealed class OriginBadgeInfo
    {
        public readonly int SubLevel;
        public readonly Picture OriginImg;
        public readonly string Description;

        private OriginBadgeInfo(Models.Protobuf.Objects.OriginBadgeInfo badgeInfo)
        {
            SubLevel = badgeInfo?.SubLevel ?? -1;
            OriginImg = badgeInfo?.OriginImg;
            Description = badgeInfo?.Description ?? string.Empty;
        }

        public static implicit operator OriginBadgeInfo(Models.Protobuf.Objects.OriginBadgeInfo badgeInfo) => new OriginBadgeInfo(badgeInfo);
    }
}
