using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPieceGift : AProtoBase
    {
        [ProtoMember(1)]
        public long GiftId { get; }

        [ProtoMember(2)]
        public PatternRef NameRef { get; }

        [ProtoMember(3)]
        public GiftShowType ShowType { get; }

        [ProtoMember(4)]
        public long ColorId { get; }
    }
}
