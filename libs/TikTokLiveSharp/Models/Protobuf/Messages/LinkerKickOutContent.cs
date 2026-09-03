using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerKickOutContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public KickoutReason KickoutReason { get; }
    }
}
