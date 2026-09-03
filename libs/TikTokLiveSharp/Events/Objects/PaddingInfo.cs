using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PaddingInfo
    {
        public readonly bool UseSpecific;
        public readonly int MiddlePadding;
        public readonly int BadgeWidth;
        public readonly int LeftPadding;
        public readonly int RightPadding;
        public readonly int IconTopPadding;
        public readonly int IconBottomPadding;
        public readonly HorizontalPaddingRule HorizontalPaddingRule;
        public readonly VerticalPaddingRule VerticalPaddingRule;

        private PaddingInfo(Models.Protobuf.Objects.PaddingInfo paddingInfo)
        {
            UseSpecific = paddingInfo?.UseSpecific ?? false;
            MiddlePadding = paddingInfo?.MiddlePadding ?? -1;
            BadgeWidth = paddingInfo?.BadgeWidth ?? -1;
            LeftPadding = paddingInfo?.LeftPadding ?? -1;
            RightPadding = paddingInfo?.RightPadding ?? -1;
            IconTopPadding = paddingInfo?.IconTopPadding ?? -1;
            IconBottomPadding = paddingInfo?.IconBottomPadding ?? -1;
            HorizontalPaddingRule = paddingInfo?.HorizontalPaddingRule ?? HorizontalPaddingRule.HorizontalPaddingRuleUseMiddleAndWidth;
            VerticalPaddingRule = paddingInfo?.VerticalPaddingRule ?? VerticalPaddingRule.VerticalPaddingRuleUseDefault;
        }

        public static implicit operator PaddingInfo(Models.Protobuf.Objects.PaddingInfo info) => new PaddingInfo(info);
    }
}
