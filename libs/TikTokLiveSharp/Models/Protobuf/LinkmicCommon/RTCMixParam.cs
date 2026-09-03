using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCMixParam : AProtoBase
    {
        [ProtoMember(1)]
        public int VideoBitrateKbps { get; }
    }
}
