using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCVideoParam : AProtoBase
    {
        [ProtoMember(1)]
        public int Width { get; }

        [ProtoMember(2)]
        public int Height { get; }

        [ProtoMember(3)]
        public int Fps { get; }

        [ProtoMember(4)]
        public int BitrateKbps { get; }
    }
}
