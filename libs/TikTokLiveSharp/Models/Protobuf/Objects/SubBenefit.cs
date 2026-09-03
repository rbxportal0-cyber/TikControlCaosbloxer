using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubBenefit : AProtoBase
    {
        [ProtoMember(1)]
        public BenefitType BenefitType { get; }

        [ProtoMember(2)]
        public Image BenefitImage { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string BenefitDescription { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string BackgroundColor { get; } = string.Empty;
    }
}
