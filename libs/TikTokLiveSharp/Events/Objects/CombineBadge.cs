using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CombineBadge
    {
        public readonly BadgeDisplayType DisplayType;
        public readonly Picture Icon;
        public readonly BadgeText Text;
        public readonly string String;
        public readonly PaddingInfo Padding;
        public readonly FontStyle FontStyle;
        public readonly ProfileCardPanel ProfileCardPanel;
        public readonly CombineBadgeBackground Background;
        public readonly CombineBadgeBackground BackgroundDarkMode;
        public readonly bool IconAutoMirrored;
        public readonly bool BackgroundAutoMirrored;
        public readonly int PublicScreenShowStyle;
        public readonly int PersonalCardShowStyle;
        public readonly int RankListOnlineAudienceShowStyle;
        public readonly int MultiGuestShowStyle;
        public readonly ArrowConfig ArrowConfig;
        public readonly PaddingInfo PaddingNewFont;

        private CombineBadge(Models.Protobuf.Objects.CombineBadge badge)
        {
            DisplayType = badge?.DisplayType ?? BadgeDisplayType.BadgeDisplayType_Unknown;
            Icon = badge?.Icon;
            Text = badge?.Text;
            String = badge?.Str ?? string.Empty;
            Padding = badge?.Padding;
            FontStyle = badge?.FontStyle;
            ProfileCardPanel = badge?.ProfileCardPanel;
            Background = badge?.Background;
            BackgroundDarkMode = badge?.BackgroundDarkMode;
            IconAutoMirrored = badge?.IconAutoMirrored ?? false;
            BackgroundAutoMirrored = badge?.BackgroundAutoMirrored ?? false;
            PublicScreenShowStyle = badge?.PublicScreenShowStyle ?? -1;
            PersonalCardShowStyle = badge?.PersonalCardShowStyle ?? -1;
            RankListOnlineAudienceShowStyle = badge?.RankListOnlineAudienceShowStyle ?? -1;
            MultiGuestShowStyle = badge?.MultiGuestShowStyle ?? -1;
            ArrowConfig = badge?.ArrowConfig;
            PaddingNewFont = badge?.PaddingNewFont;
        }

        public static implicit operator CombineBadge(Models.Protobuf.Objects.CombineBadge badge) => new CombineBadge(badge);
    }
}
