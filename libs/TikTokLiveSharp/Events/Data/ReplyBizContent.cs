using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ReplyBizContent
    {
        public readonly int LinkType;
        public readonly int IsTurnOffInvitation;
        public readonly User ReplyUser;

        private ReplyBizContent(Models.Protobuf.Messages.ReplyBizContent content)
        {
            LinkType = content?.LinkType ?? -1;
            IsTurnOffInvitation = content?.IsTurnOffInvitation ?? -1;
            ReplyUser = content?.ReplyUserInfo;
        }

        public static implicit operator ReplyBizContent(Models.Protobuf.Messages.ReplyBizContent content) => new ReplyBizContent(content);
    }
}
