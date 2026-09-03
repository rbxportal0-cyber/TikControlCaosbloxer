using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class InviteBizContent
    {
        public readonly LinkmicUserSettingInfo AnchorSettingInfo;
        public readonly ContentInviteSource InviteSource;
        public readonly User Operator;
        public readonly LinkMicUserAdminType OperatorLinkAdminType;
        public readonly User Invitee;

        private InviteBizContent(Models.Protobuf.Messages.InviteBizContent content)
        {
            AnchorSettingInfo = content?.AnchorSettingInfo;
            InviteSource = content?.InviteSource ?? ContentInviteSource.Invite_Source_Unknown;
            Operator = content?.OperatorUserInfo;
            OperatorLinkAdminType = content?.OperatorLinkAdminType ?? LinkMicUserAdminType.Undefined_Type;
            Invitee = content?.InviteeUserInfo;
        }

        public static implicit operator InviteBizContent(Models.Protobuf.Messages.InviteBizContent content) => new InviteBizContent(content);
    }
}
