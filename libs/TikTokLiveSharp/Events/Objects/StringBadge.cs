using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class StringBadge
    {
        public readonly BadgeDisplayType DisplayType;
        public readonly string String;

        private StringBadge(Models.Protobuf.Objects.StringBadge badge)
        {
            DisplayType = badge?.DisplayType ?? BadgeDisplayType.BadgeDisplayType_Unknown;
            String = badge?.Str ?? string.Empty;
        }

        public static implicit operator StringBadge(Models.Protobuf.Objects.StringBadge badge) => new StringBadge(badge);
    }
}
