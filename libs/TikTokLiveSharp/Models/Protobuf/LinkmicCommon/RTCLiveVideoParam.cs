using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCLiveVideoParam : AProtoBase
    {
        [ProtoMember(1)]
        public int StrategyId { get; }

        [ProtoMember(2)]
        public RTCVideoParam Params { get; }
    }
}
