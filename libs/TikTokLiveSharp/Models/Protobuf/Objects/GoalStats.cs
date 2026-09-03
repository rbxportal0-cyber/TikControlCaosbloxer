using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalStats : AProtoBase
    {
        [ProtoMember(1)]
        public long TotalCoins { get; }

        [ProtoMember(2)]
        public long TotalContributor { get; }

        [ProtoMember(3)]
        public GoalComparison Comparison { get; }
    }
}
