using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class KickOutContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Offliner { get; }

        [ProtoMember(2)]
        public KickoutReason KickoutReason { get; }
    }
}
