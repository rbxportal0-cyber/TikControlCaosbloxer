using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class InviteContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Invitor { get; }

        [ProtoMember(2)]
        public RTCExtraInfo InviteeRtcExtInfo { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string InvitorLinkMicId { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string InviteeLinkMicId { get; } = string.Empty;

        [ProtoMember(5)]
        public bool IsOwner { get; }

        [ProtoMember(6)]
        public Position Pos { get; }

        [ProtoMember(7)]
        public DSLConfig Dsl { get; }

        [ProtoMember(8)]
        public Player Invitee { get; }

        [ProtoMember(9)]
        public Player Operator { get; }
    }
}
