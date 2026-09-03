using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long MessageType { get; }

        [ProtoMember(3)]
        public long LinkerId { get; }

        [ProtoMember(4)]
        public long Scene { get; }

        [ProtoMember(5)]
        public LinkerInviteContent InviteContent { get; }

        [ProtoMember(6)]
        public LinkerReplyContent ReplyContent { get; }

        [ProtoMember(7)]
        public LinkerCreateContent CreateContent { get; }

        [ProtoMember(8)]
        public LinkerCloseContent CloseContent { get; }

        [ProtoMember(9)]
        public LinkerEnterContent EnterContent { get; }

        [ProtoMember(10)]
        public LinkerLeaveContent LeaveContent { get; }

        [ProtoMember(11)]
        public LinkerCancelContent CancelContent { get; }

        [ProtoMember(12)]
        public LinkerKickOutContent KickOutContent { get; }

        [ProtoMember(13)]
        public LinkerLinkedListChangeContent LinkedListChangeContent { get; }

        [ProtoMember(14)]
        public LinkerUpdateUserContent UpdateUserContent { get; }

        [ProtoMember(15)]
        public LinkerWaitingListChangeContent WaitingListChangeContent { get; }

        [ProtoMember(16)]
        public LinkerMuteContent MuteContent { get; }

        [ProtoMember(17)]
        public LinkerRandomMatchContent RandomMatchContent { get; }

        [ProtoMember(18)]
        public LinkerUpdateUserSettingContent UpdateUserSettingContent { get; }

        [ProtoMember(19)]
        public LinkerMicIdxUpdateContent MicIdxUpdateContent { get; }

        [ProtoMember(20)]
        public LinkerListChangeContent ListChangeContent { get; }

        [ProtoMember(21)]
        public CohostListChangeContent CohostListChangeContent { get; }

        [ProtoMember(22)]
        public LinkerMediaChangeContent MediaChangeContent { get; }

        [ProtoMember(23)]
        public LinkerAcceptNoticeContent ReplyAcceptNoticeContent { get; }

        [ProtoMember(101)]
        public LinkerSysKickOutContent SysKickOutContent { get; }

        [ProtoMember(102)]
        public LinkmicUserToastContent UserToastContent { get; }

        [ProtoMember(200)]
        [DefaultValue("")]
        public string Extra { get; } = string.Empty;

        [ProtoMember(201)]
        public long ExpireTimestamp { get; }

        [ProtoMember(202)]
        [DefaultValue("")]
        public string TransferExtra { get; } = string.Empty;
    }
}
