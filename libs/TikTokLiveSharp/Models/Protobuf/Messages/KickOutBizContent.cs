using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class KickOutBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public User OperatorUserInfo { get; }

        [ProtoMember(2)]
        public LinkMicUserAdminType OperatorLinkAdminType { get; }

        [ProtoMember(3)]
        public User KickPlayerUserInfo { get; }
    }
}
