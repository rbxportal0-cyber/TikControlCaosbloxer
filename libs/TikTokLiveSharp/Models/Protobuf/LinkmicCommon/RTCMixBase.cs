using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCMixBase : AProtoBase
    {
        [ProtoMember(1)]
        public int Bitrate { get; }
    }
}
