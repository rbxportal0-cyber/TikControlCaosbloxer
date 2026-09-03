using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubGift : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string SendSubGiftNotice { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string SendUrl { get; } = string.Empty;

        [ProtoMember(3)]
        public long SubGiftNum { get; }

        [ProtoMember(4)]
        public bool ShowEntrance { get; }
    }
}
