using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubCustomizedBenefitMedia : AProtoBase
    {
        [ProtoMember(1)]
        public Image IconImg { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Url { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string BackgroundColor { get; } = string.Empty;
    }
}
