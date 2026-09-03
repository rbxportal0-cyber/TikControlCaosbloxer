using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PermitJoinGroupBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public ReplyStatus ReplyStatus { get; }
    }
}
