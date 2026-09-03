using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BarrageTypeSubscribeGiftParam : AProtoBase
    {
        [ProtoMember(1)]
        public long GiftSubCount { get; }

        [ProtoMember(2)]
        public bool ShowGiftSubCount { get; }
    }
}
