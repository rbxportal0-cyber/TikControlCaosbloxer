using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCOther : AProtoBase
    {
        [ProtoMember(1)]
        public int MaxTranscodingCbIntervalSecond { get; }
    }
}
