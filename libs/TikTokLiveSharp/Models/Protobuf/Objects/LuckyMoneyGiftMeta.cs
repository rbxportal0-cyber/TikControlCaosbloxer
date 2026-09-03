using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LuckyMoneyGiftMeta : AProtoBase
    {
        [ProtoMember(1)]
        public Image Deprecated1 { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Deprecated2 { get; } = string.Empty;

        [ProtoMember(3)]
        public long Deprecated3 { get; }

        [ProtoMember(4)]
        public int Deprecated4 { get; }

        [ProtoMember(5)]
        public Image Deprecated5 { get; }
    }
}
