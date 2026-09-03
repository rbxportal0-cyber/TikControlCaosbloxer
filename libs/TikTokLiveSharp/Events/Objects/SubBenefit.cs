using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubBenefit
    {
        public readonly BenefitType BenefitType;
        public readonly Picture BenefitImage;
        public readonly string BenefitDescription;
        public readonly string BackgroundColor;

        private SubBenefit(Models.Protobuf.Objects.SubBenefit subBenefit)
        {
            BenefitType = subBenefit?.BenefitType ?? BenefitType.BenefitTypeUnknown;
            BenefitImage = subBenefit?.BenefitImage;
            BenefitDescription = subBenefit?.BenefitDescription ?? string.Empty;
            BackgroundColor = subBenefit?.BackgroundColor ?? string.Empty;
        }

        public static implicit operator SubBenefit(Models.Protobuf.Objects.SubBenefit subBenefit) => new SubBenefit(subBenefit);
    }
}
