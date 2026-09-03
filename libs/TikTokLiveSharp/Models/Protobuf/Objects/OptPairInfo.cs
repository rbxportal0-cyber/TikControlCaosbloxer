using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class OptPairInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long MappingId { get; }

        [ProtoMember(2)]
        public long ExpectedTimeSec { get; }

        [ProtoMember(3)]
        public OptPairStatus OptPairStatus { get; }
    }
}
