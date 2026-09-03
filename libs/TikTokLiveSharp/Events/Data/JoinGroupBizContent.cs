using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class JoinGroupBizContent
    {
        public readonly int FromRoomAgeRestricted;
        public readonly Tag FromTag;
        public readonly PerceptionDialogInfo Dialog;
        public readonly PunishEventInfo PunishInfo;
        public readonly JoinGroupMessageExtra JoinGroupMsgExtra;

        private JoinGroupBizContent(Models.Protobuf.Messages.JoinGroupBizContent content)
        {
            FromRoomAgeRestricted = content?.FromRoomAgeRestricted ?? -1;
            FromTag = content?.FromTag;
            Dialog = content?.Dialog;
            PunishInfo = content?.PunishInfo;
            JoinGroupMsgExtra = content?.JoinGroupMsgExtra;
        }

        public static implicit operator JoinGroupBizContent(Models.Protobuf.Messages.JoinGroupBizContent content) => new JoinGroupBizContent(content);
    }
}
