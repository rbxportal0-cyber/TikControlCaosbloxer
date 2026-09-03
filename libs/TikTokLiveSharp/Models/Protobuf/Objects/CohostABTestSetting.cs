using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CohostABTestSetting : AProtoBase
    {
        [ProtoMember(1)]
        public long Key { get; }

        [ProtoMember(2)]
        public CohostABTestList Value { get; }
    }
}
