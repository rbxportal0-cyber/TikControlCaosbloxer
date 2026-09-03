using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubCustomizedBenefit : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string BenefitIdStr { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string OriginalBenefitIdStr { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string OriginalTemplateIdStr { get; } = string.Empty;

        [ProtoMember(10)]
        public BenefitType BenefitType { get; }

        [ProtoMember(11)]
        public SubCustomizedBenefitMedia BenefitMedia { get; }

        [ProtoMember(20)]
        public AuditStatus AuditStatus { get; }

        [ProtoMember(21)]
        public SubBenefitConfigStatus ConfigStatus { get; }

        [ProtoMember(22)]
        public SubBenefitEnableStatus EnableStatus { get; }

        [ProtoMember(23)]
        public SubBenefitBlockStatus BlockStatus { get; }

        [ProtoMember(24)]
        public SubBenefitUserConfigStatus UserConfigStatus { get; }
    }
}
