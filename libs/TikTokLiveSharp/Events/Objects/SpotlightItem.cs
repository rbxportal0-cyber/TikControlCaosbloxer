using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SpotlightItem
    {
        public readonly long Id;
        public readonly Picture Image;
        public readonly SpotlightReviewStatus ReviewStatus;
        public readonly bool IsPinned;
        public readonly long CreateTimeSecond;

        private SpotlightItem(Models.Protobuf.Objects.SpotlightItem item)
        {
            Id = item?.Id ?? -1;
            Image = item?.Image;
            ReviewStatus = item?.ReviewStatus ?? SpotlightReviewStatus.SpotlightReviewStatusUnknown;
            IsPinned = item?.IsPinned ?? false;
            CreateTimeSecond = item?.CreateTimeSecond ?? -1;
        }

        public static implicit operator SpotlightItem(Models.Protobuf.Objects.SpotlightItem item) => new SpotlightItem(item);
    }
}
