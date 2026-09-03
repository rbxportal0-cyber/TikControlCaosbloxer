using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCBitrateMap : AProtoBase
    {
        [ProtoMember(1)]
        public int XX1 { get; }

        [ProtoMember(2)]
        public int XX2 { get; }

        [ProtoMember(3)]
        public int XX3 { get; }

        [ProtoMember(4)]
        public int XX4 { get; }
    }
}
