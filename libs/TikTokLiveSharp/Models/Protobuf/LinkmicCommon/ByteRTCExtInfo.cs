using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class ByteRTCExtInfo : AProtoBase
    {
        [ProtoMember(1)]
        public int DefaultSignalingServerFirst { get; }
    }
}
