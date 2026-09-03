using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PermitBizContent
    {
        public readonly LinkmicUserSettingInfo AnchorSettingInfo;
        public readonly long ExpireTimestamp;
        public readonly User Operator;
        public readonly LinkMicUserAdminType OperatorLinkAdminType;

        private PermitBizContent(Models.Protobuf.Messages.PermitBizContent content)
        {
            AnchorSettingInfo = content?.AnchorSettingInfo;
            ExpireTimestamp = content?.ExpireTimestamp ?? -1;
            Operator = content?.OperatorUserInfo;
            OperatorLinkAdminType = content?.OperatorLinkAdminType ?? LinkMicUserAdminType.Undefined_Type;
        }

        public static implicit operator PermitBizContent(Models.Protobuf.Messages.PermitBizContent content) => new PermitBizContent(content);
    }
}
