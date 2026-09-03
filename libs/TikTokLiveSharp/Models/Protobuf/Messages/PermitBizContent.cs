using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PermitBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public LinkmicUserSettingInfo AnchorSettingInfo { get; }

        [ProtoMember(2)]
        public long ExpireTimestamp { get; }

        [ProtoMember(3)]
        public User OperatorUserInfo { get; }

        [ProtoMember(4)]
        public LinkMicUserAdminType OperatorLinkAdminType { get; }
    }
}
