using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalComparison : AProtoBase
    {
        [ProtoMember(1)]
        public long CoinsIncr { get; }

        [ProtoMember(2)]
        public long ContributorIncr { get; }
    }
}
