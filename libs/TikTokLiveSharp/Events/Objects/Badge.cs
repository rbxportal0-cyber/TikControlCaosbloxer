using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Badge
    {
        public enum DataCase
        {
            None = 0,
            Image = 20,
            Text = 21,
            String = 22,
            Combine = 23
        }

        public readonly DataCase BadgeData;
        public readonly BadgeDisplayType DisplayType;
        public readonly BadgePriorityType PriorityType;
        public readonly BadgeSceneType SceneType;
        public readonly BadgeTextPosition Position;
        public readonly DisplayStatus DisplayStatus;
        public readonly long GreyedByClient;
        public readonly BadgeExhibitionType ExhibitionType;
        public readonly string OpenWebUrl;
        public readonly bool Display;
        public readonly PrivilegeLogExtra PrivilegeLogExtra;
        public readonly ImageBadge Image;
        public readonly TextBadge Text;
        public readonly StringBadge String;
        public readonly CombineBadge Combine;

        private Badge(Models.Protobuf.Objects.BadgeStruct badge)
        {
            BadgeData = badge?.BadgeData != null ? (DataCase)badge.BadgeData : DataCase.None;
            DisplayType = badge?.DisplayType ?? BadgeDisplayType.BadgeDisplayType_Unknown;
            PriorityType = badge?.PriorityType ?? BadgePriorityType.BadgePriorityType_Unknown;
            SceneType = badge?.SceneType ?? BadgeSceneType.BadgeSceneType_Unknown;
            Position = badge?.Position ?? BadgeTextPosition.BadgeTextPositionUnknown;
            DisplayStatus = badge?.DisplayStatus ?? DisplayStatus.DisplayStatusNormal;
            GreyedByClient = badge?.GreyedByClient ?? -1;
            ExhibitionType = badge?.ExhibitionType ?? BadgeExhibitionType.BadgeExhibitionTypeBadge;
            OpenWebUrl = badge?.OpenWebUrl ?? string.Empty;
            Display = badge?.Display ?? false;
            PrivilegeLogExtra = badge?.PrivilegeLogExtra;
            Image = badge?.Image;
            Text = badge?.Text;
            String = badge?.Str;
            Combine = badge?.Combine;
        }

        public static implicit operator Badge(Models.Protobuf.Objects.BadgeStruct badge) => new Badge(badge);
    }
}
