using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftInCart : AProtoBase
    {
        [ProtoMember(1)]
        public long GiftId { get; }

        [ProtoMember(2)]
        public long ColorId { get; }
    }
}
