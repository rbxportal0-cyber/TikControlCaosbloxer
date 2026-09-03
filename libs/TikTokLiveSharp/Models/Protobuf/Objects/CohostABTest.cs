using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CohostABTest : AProtoBase
    {
        [ProtoMember(1)]
        public CohostABTestType ABTestType { get; }

        [ProtoMember(2)]
        public long Group { get; }
    }
}
