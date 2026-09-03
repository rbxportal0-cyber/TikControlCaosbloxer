using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CancelInviteContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Invitor { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string InvitorLinkMicId { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string InviteeLinkMicId { get; } = string.Empty;

        [ProtoMember(4)]
        public long InviteSeqId { get; }

        [ProtoMember(5)]
        public Player Invitee { get; }
    }
}
