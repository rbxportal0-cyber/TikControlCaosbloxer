using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ImageBadge
    {
        public readonly BadgeDisplayType DisplayType;
        public readonly Picture Image;

        private ImageBadge(Models.Protobuf.Objects.ImageBadge badge)
        {
            DisplayType = badge?.DisplayType ?? BadgeDisplayType.BadgeDisplayType_Unknown;
            Image = badge?.Image;
        }

        public static implicit operator ImageBadge(Models.Protobuf.Objects.ImageBadge badge) => new ImageBadge(badge);
    }
}
