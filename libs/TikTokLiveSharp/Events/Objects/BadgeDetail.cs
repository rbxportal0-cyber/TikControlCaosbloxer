using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BadgeDetail
    {
        public readonly BadgeData BadgeData;
        public readonly IReadOnlyList<BadgePreview> Previews;
        public readonly AuditStatus AbbreviationAuditStatus;
        public readonly AuditStatus DescriptionAuditStatus;
        public readonly bool Exist;

        private BadgeDetail(Models.Protobuf.Objects.BadgeDetail badgeDetail)
        {
            BadgeData = badgeDetail?.Badge;
            Previews = badgeDetail?.PreviewList?.Count > 0 ? badgeDetail.PreviewList.Select(p => (BadgePreview)p).ToList().AsReadOnly() : new List<BadgePreview>(0).AsReadOnly();
            AbbreviationAuditStatus = badgeDetail?.BadgeAbbrAuditStatus ?? AuditStatus.AuditStatusUnknown;
            DescriptionAuditStatus = badgeDetail?.BadgeDescAuditStatus ?? AuditStatus.AuditStatusUnknown;
            Exist = badgeDetail?.Exist ?? false;
        }

        public static implicit operator BadgeDetail(Models.Protobuf.Objects.BadgeDetail badgeDetail) => new BadgeDetail(badgeDetail);
    }

    public sealed class BadgeData
    {
        public readonly string Abbreviation;
        public readonly string Description;
        public readonly string Emoji;
        public readonly Picture Icon;
        public readonly BadgeType Type;
        public readonly long Id;

        private BadgeData(Models.Protobuf.Objects.Badge badge)
        {
            Abbreviation = badge?.BadgeAbbr ?? string.Empty;
            Description = badge?.BadgeDesc ?? string.Empty;
            Emoji = badge?.BadgeEmoji ?? string.Empty;
            Icon = badge?.BadgeIcon;
            Type = badge?.BadgeType ?? BadgeType.BadgeTypeNormal;
            Id = badge?.BadgeId ?? -1;
        }

        public static implicit operator BadgeData(Models.Protobuf.Objects.Badge badge) => new BadgeData(badge);
    }

    public sealed class BadgePreview
    {
        public readonly int SubLevel;
        public readonly Picture MixedImage;
        public readonly Badge Badge;

        private BadgePreview(Models.Protobuf.Objects.BadgePreview preview)
        {
            SubLevel = preview?.SubLevel ?? -1;
            MixedImage = preview?.MixedImage;
            Badge = preview?.BadgeStruct;
        }

        public static implicit operator BadgePreview(Models.Protobuf.Objects.BadgePreview preview) => new BadgePreview(preview);
    }
}
