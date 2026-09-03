using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ReplyInviteContent
    {
        public readonly Player Invitee;
        public readonly ReplyStatus ReplyStatus;
        public readonly string InviteeLinkMicId;
        public readonly Position InviteePos;
        public readonly Player InviteOperatorUser;

        private ReplyInviteContent(Models.Protobuf.Messages.ReplyInviteContent content)
        {
            Invitee = content?.Invitee;
            ReplyStatus = content?.ReplyStatus ?? ReplyStatus.Reply_Status_Unknown;
            InviteeLinkMicId = content?.InviteeLinkMicId ?? string.Empty;
            InviteePos = content?.InviteePos;
            InviteOperatorUser = content?.InviteOperatorUser;
        }

        public static implicit operator ReplyInviteContent(Models.Protobuf.Messages.ReplyInviteContent content) => new ReplyInviteContent(content);
    }
}
