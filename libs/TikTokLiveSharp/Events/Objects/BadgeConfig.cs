using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BadgeConfig
    {
        public readonly BadgeLimit Badge_Limit;
        public readonly IReadOnlyList<OriginBadgeInfo> OriginBadgeImages;

        private BadgeConfig(Models.Protobuf.Objects.BadgeConfig badgeConfig)
        {
            Badge_Limit = badgeConfig?.BadgeLmt;
            OriginBadgeImages = badgeConfig?.OriginBadgeImgList?.Count > 0 ? badgeConfig.OriginBadgeImgList.Select(b => (OriginBadgeInfo)b).ToList().AsReadOnly() : new List<OriginBadgeInfo>(0).AsReadOnly();
        }

        public static implicit operator BadgeConfig(Models.Protobuf.Objects.BadgeConfig badgeConfig) => new BadgeConfig(badgeConfig);
    }
}
