using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PermitJoinGroupBizContent
    {
        public readonly ReplyStatus ReplyStatus;

        private PermitJoinGroupBizContent(Models.Protobuf.Messages.PermitJoinGroupBizContent content)
        {
            ReplyStatus = content?.ReplyStatus ?? ReplyStatus.Reply_Status_Unknown;
        }

        public static implicit operator PermitJoinGroupBizContent(Models.Protobuf.Messages.PermitJoinGroupBizContent content) => new PermitJoinGroupBizContent(content);
    }
}
