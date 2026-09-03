using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BenefitView
    {
        public readonly BenefitType Type;
        public readonly Picture Image;
        public readonly string Description;
        public readonly string BackgroundColor;
        public readonly Picture NavIcon;

        private BenefitView(Models.Protobuf.Objects.BenefitView view)
        {
            Type = view?.BenefitType ?? BenefitType.BenefitTypeUnknown;
            Image = view?.BenefitImage;
            Description = view?.BenefitDescription ?? string.Empty;
            BackgroundColor = view?.BackgroundColor ?? string.Empty;
            NavIcon = view?.NavIcon;
        }

        public static implicit operator BenefitView(Models.Protobuf.Objects.BenefitView view) => new BenefitView(view);
    }
}
