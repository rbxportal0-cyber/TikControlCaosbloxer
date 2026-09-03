using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class Position : AProtoBase
    {
        [ProtoMember(1)]
        public int Type { get; }

        [ProtoMember(2)]
        public LinkPosition Link { get; }
    }
}
