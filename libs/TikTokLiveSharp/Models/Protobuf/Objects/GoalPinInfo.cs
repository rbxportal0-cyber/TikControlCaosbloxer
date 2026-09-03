using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalPinInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool Pin { get; }

        [ProtoMember(2)]
        public bool Unpin { get; }

        [ProtoMember(3)]
        public long PinEndTime { get; }
    }
}
