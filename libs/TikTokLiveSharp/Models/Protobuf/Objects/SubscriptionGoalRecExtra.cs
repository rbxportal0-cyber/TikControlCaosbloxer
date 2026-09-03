using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubscriptionGoalRecExtra : AProtoBase
    {
        [ProtoMember(1)]
        public int SubscriptionCount { get; }
    }
}
