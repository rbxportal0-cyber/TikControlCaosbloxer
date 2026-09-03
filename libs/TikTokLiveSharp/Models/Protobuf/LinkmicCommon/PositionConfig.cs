using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class PositionConfig : AProtoBase
    {
        [ProtoMember(1)]
        public int MaxPosition { get; }
    }
}
