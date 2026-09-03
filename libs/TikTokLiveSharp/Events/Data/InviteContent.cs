using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class InviteContent
    {
        public readonly Player Invitor;
        public readonly RTCExtraInfo InviteeRtcExtInfo;
        public readonly string InvitorLinkMicId;
        public readonly string InviteeLinkMicId;
        public readonly bool IsOwner;
        public readonly Position Pos;
        public readonly DSLConfig Dsl;
        public readonly Player Invitee;
        public readonly Player Operator;

        private InviteContent(Models.Protobuf.Messages.InviteContent content)
        {
            Invitor = content?.Invitor;
            InviteeRtcExtInfo = content?.InviteeRtcExtInfo;
            InvitorLinkMicId = content?.InvitorLinkMicId ?? string.Empty;
            InviteeLinkMicId = content?.InviteeLinkMicId ?? string.Empty;
            IsOwner = content?.IsOwner ?? false;
            Pos = content?.Pos;
            Dsl = content?.Dsl;
            Invitee = content?.Invitee;
            Operator = content?.Operator;
        }

        public static implicit operator InviteContent(Models.Protobuf.Messages.InviteContent content) => new InviteContent(content);
    }
}
