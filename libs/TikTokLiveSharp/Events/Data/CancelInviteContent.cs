using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class CancelInviteContent
    {
        public readonly Player Invitor;
        public readonly string InvitorLinkMicId;
        public readonly string InviteeLinkMicId;
        public readonly long InviteSeqId;
        public readonly Player Invitee;

        private CancelInviteContent(Models.Protobuf.Messages.CancelInviteContent content)
        {
            Invitor = content?.Invitor;
            InvitorLinkMicId = content?.InvitorLinkMicId ?? string.Empty;
            InviteeLinkMicId = content?.InviteeLinkMicId ?? string.Empty;
            InviteSeqId = content?.InviteSeqId ?? -1;
            Invitee = content?.Invitee;
        }

        public static implicit operator CancelInviteContent(Models.Protobuf.Messages.CancelInviteContent content) => new CancelInviteContent(content);
    }
}
