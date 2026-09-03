using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftInfoInBox : AProtoBase
    {
        [ProtoMember(1)]
        public long GiftId { get; }

        [ProtoMember(2)]
        public long EffectId { get; }

        [ProtoMember(3)]
        public long ColorId { get; }

        [ProtoMember(4)]
        public int RemainTimes { get; }
    }
}
