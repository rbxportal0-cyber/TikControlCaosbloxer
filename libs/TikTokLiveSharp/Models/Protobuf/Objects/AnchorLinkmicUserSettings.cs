using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AnchorLinkmicUserSettings : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsTurnOn { get; }

        [ProtoMember(2)]
        public bool AcceptMultiLinkmic { get; }

        [ProtoMember(3)]
        public bool AcceptNotFollowerInvite { get; }

        [ProtoMember(4)]
        public bool AllowGiftToOtherAnchors { get; }

        [ProtoMember(5)]
        public bool BlockInvitationOfThisLive { get; }

        [ProtoMember(6)]
        public bool ReceiveFriendMultiHostInvites { get; }

        [ProtoMember(7)]
        public bool ReceiveFriendMultiHostApplication { get; }

        [ProtoMember(8)]
        public bool BlockThisMultiHostInvites { get; }

        [ProtoMember(9)]
        public bool BlockThisMultiHostApplication { get; }

        [ProtoMember(10)]
        public bool ReceiveNotFriendMultiHostInvites { get; }

        [ProtoMember(11)]
        public bool ReceiveNotFriendMultiHostApplication { get; }

        [ProtoMember(12)]
        public bool AllowLiveNoticeOfFriends { get; }
    }
}
