using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubGoalPinCard : AProtoBase
    {
        [ProtoMember(1)]
        public long GoalId { get; }

        [ProtoMember(2)]
        public long TimeToLive { get; }

        [ProtoMember(3)]
        public SubPinCardText Desc { get; }

        [ProtoMember(4)]
        public long Target { get; }

        [ProtoMember(5)]
        public long Progress { get; }
    }
}
