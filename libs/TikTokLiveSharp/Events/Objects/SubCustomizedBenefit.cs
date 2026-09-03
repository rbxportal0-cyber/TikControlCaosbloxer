using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubCustomizedBenefit
    {
        public readonly string BenefitIdString;
        public readonly string OriginalBenefitIdString;
        public readonly string OriginalTemplateIdString;
        public readonly BenefitType BenefitType;
        public readonly SubCustomizedBenefitMedia BenefitMedia;
        public readonly AuditStatus AuditStatus;
        public readonly SubBenefitConfigStatus ConfigStatus;
        public readonly SubBenefitEnableStatus EnableStatus;
        public readonly SubBenefitBlockStatus BlockStatus;
        public readonly SubBenefitUserConfigStatus UserConfigStatus;

        private SubCustomizedBenefit(Models.Protobuf.Objects.SubCustomizedBenefit benefit)
        {
            BenefitIdString = benefit?.BenefitIdStr ?? string.Empty;
            OriginalBenefitIdString = benefit?.OriginalBenefitIdStr ?? string.Empty;
            OriginalTemplateIdString = benefit?.OriginalTemplateIdStr ?? string.Empty;
            BenefitType = benefit?.BenefitType ?? BenefitType.BenefitTypeUnknown;
            BenefitMedia = benefit?.BenefitMedia;
            AuditStatus = benefit?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
            ConfigStatus = benefit?.ConfigStatus ?? SubBenefitConfigStatus.SubBenefitConfigStatusUnknown;
            EnableStatus = benefit?.EnableStatus ?? SubBenefitEnableStatus.SubBenefitEnableStatusUnknown;
            BlockStatus = benefit?.BlockStatus ?? SubBenefitBlockStatus.SubBenefitBlockStatusUnblock;
            UserConfigStatus = benefit?.UserConfigStatus ?? SubBenefitUserConfigStatus.SubBenefitUserConfigStatusUnknown;
        }

        public static implicit operator SubCustomizedBenefit(Models.Protobuf.Objects.SubCustomizedBenefit benefit) => new SubCustomizedBenefit(benefit);
    }
}
