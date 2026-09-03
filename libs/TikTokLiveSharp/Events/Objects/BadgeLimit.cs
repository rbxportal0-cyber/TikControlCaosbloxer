namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BadgeLimit
    {
        public readonly int AbbreviationCharacterLimit;
        public readonly int DescriptionCharacterLimit;

        private BadgeLimit(Models.Protobuf.Objects.BadgeLimit badgeLimit)
        {
            AbbreviationCharacterLimit = badgeLimit?.AbbrCharCntLmt ?? -1;
            DescriptionCharacterLimit = badgeLimit?.DescCharCntLmt ?? -1;
        }

        public static implicit operator BadgeLimit(Models.Protobuf.Objects.BadgeLimit badgeLimit) => new BadgeLimit(badgeLimit);
    }
}
