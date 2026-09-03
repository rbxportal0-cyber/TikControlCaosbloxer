using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftBanner : AProtoBase
    {
        [ProtoMember(1)]
        public Text DisplayText { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string DisplayTextBgColor { get; } = string.Empty;

        [ProtoMember(3)]
        public Image BoxImg { get; }

        [ProtoMember(4)]
        public Image BgImg { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string SchemeUrl { get; } = string.Empty;

        [ProtoMember(6)]
        public bool Animate { get; }

        [ProtoMember(7)]
        public long Deprecated1 { get; }

        [ProtoMember(8)]
        public long Deprecated2 { get; }
    }
}
