using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ProfileCardPanel
    {
        public readonly bool UseNewProfileCardStyle;
        public readonly BadgeTextPosition BadgeTextPosition;
        public readonly ProjectionConfig ProjectionConfig;
        public readonly ProfileContent ProfileContent;
        public readonly SeparatorConfig SeparatorConfig;

        private ProfileCardPanel(Models.Protobuf.Objects.ProfileCardPanel panel)
        {
            UseNewProfileCardStyle = panel?.UseNewProfileCardStyle ?? false;
            BadgeTextPosition = panel?.BadgeTextPosition ?? BadgeTextPosition.BadgeTextPositionUnknown;
            ProjectionConfig = panel?.ProjectionConfig;
            ProfileContent = panel?.ProfileContent;
            SeparatorConfig = panel?.SeparatorConfig;
        }

        public static implicit operator ProfileCardPanel(Models.Protobuf.Objects.ProfileCardPanel panel) => new ProfileCardPanel(panel);
    }
}
