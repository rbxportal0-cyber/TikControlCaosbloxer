using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ReplyInviteContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Invitee { get; }

        [ProtoMember(2)]
        public ReplyStatus ReplyStatus { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string InviteeLinkMicId { get; } = string.Empty;

        [ProtoMember(4)]
        public Position InviteePos { get; }

        [ProtoMember(5)]
        public Player InviteOperatorUser { get; }
    }
}
