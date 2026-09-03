using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class KickOutBizContent
    {
        public readonly User Operator;
        public readonly LinkMicUserAdminType OperatorLinkAdminType;
        public readonly User KickPlayer;

        private KickOutBizContent(Models.Protobuf.Messages.KickOutBizContent content)
        {
            Operator = content?.OperatorUserInfo;
            OperatorLinkAdminType = content?.OperatorLinkAdminType ?? LinkMicUserAdminType.Undefined_Type;
            KickPlayer = content?.KickPlayerUserInfo;
        }

        public static implicit operator KickOutBizContent(Models.Protobuf.Messages.KickOutBizContent content) => new KickOutBizContent(content);
    }
}
