using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SubCapsuleMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public Text Description { get; }

        [ProtoMember(3)]
        public Text BtnName { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string BtnUrl { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string CapsuleScene { get; } = string.Empty;

        [ProtoMember(6)]
        public long FromUserId { get; }
    }
}
