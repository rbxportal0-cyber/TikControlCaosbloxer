using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events
{
    public sealed class LinkMessage : AMessageData
    {
        public readonly long MessageType;
        public readonly long LinkerId;
        public readonly long Scene;
        public readonly LinkerInviteContent InviteContent;
        public readonly LinkerReplyContent ReplyContent;
        public readonly LinkerCreateContent CreateContent;
        public readonly LinkerCloseContent CloseContent;
        public readonly LinkerEnterContent EnterContent;
        public readonly LinkerLeaveContent LeaveContent;
        public readonly LinkerCancelContent CancelContent;
        public readonly LinkerKickOutContent KickOutContent;
        public readonly LinkerLinkedListChangeContent LinkedListChangeContent;
        public readonly LinkerUpdateUserContent UpdateUserContent;
        public readonly LinkerWaitingListChangeContent WaitingListChangeContent;
        public readonly LinkerMuteContent MuteContent;
        public readonly LinkerRandomMatchContent RandomMatchContent;
        public readonly LinkerUpdateUserSettingContent UpdateUserSettingContent;
        public readonly LinkerMicIdxUpdateContent MicIdxUpdateContent;
        public readonly LinkerListChangeContent ListChangeContent;
        public readonly CohostListChangeContent CohostListChangeContent;
        public readonly LinkerMediaChangeContent MediaChangeContent;
        public readonly LinkerAcceptNoticeContent ReplyAcceptNoticeContent;
        public readonly LinkerSysKickOutContent SysKickOutContent;
        public readonly LinkmicUserToastContent UserToastContent;
        public readonly string Extra;
        public readonly long ExpireTimestamp;
        public readonly string TransferExtra;

        internal LinkMessage(Models.Protobuf.Messages.LinkMessage msg)
            : base(msg?.Header)
        {
            MessageType = msg?.MessageType ?? -1;
            LinkerId = msg?.LinkerId ?? -1;
            Scene = msg?.Scene ?? -1;
            InviteContent = msg?.InviteContent;
            ReplyContent = msg?.ReplyContent;
            CreateContent = msg?.CreateContent;
            CloseContent = msg?.CloseContent;
            EnterContent = msg?.EnterContent;
            LeaveContent = msg?.LeaveContent;
            CancelContent = msg?.CancelContent;
            KickOutContent = msg?.KickOutContent;
            LinkedListChangeContent = msg?.LinkedListChangeContent;
            UpdateUserContent = msg?.UpdateUserContent;
            WaitingListChangeContent = msg?.WaitingListChangeContent;
            MuteContent = msg?.MuteContent;
            RandomMatchContent = msg?.RandomMatchContent;
            UpdateUserSettingContent = msg?.UpdateUserSettingContent;
            MicIdxUpdateContent = msg?.MicIdxUpdateContent;
            ListChangeContent = msg?.ListChangeContent;
            CohostListChangeContent = msg?.CohostListChangeContent;
            MediaChangeContent = msg?.MediaChangeContent;
            ReplyAcceptNoticeContent = msg?.ReplyAcceptNoticeContent;
            SysKickOutContent = msg?.SysKickOutContent;
            UserToastContent = msg?.UserToastContent;
            Extra = msg?.Extra ?? string.Empty;
            ExpireTimestamp = msg?.ExpireTimestamp ?? -1;
            TransferExtra = msg?.TransferExtra ?? string.Empty;
        }
    }
}