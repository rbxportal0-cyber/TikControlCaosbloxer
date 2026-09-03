using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextPieceGift
    {
        public readonly long GiftId;

        public readonly PatternRef NameRef;

        public readonly GiftShowType ShowType;

        public readonly long ColorId;

        private TextPieceGift(Models.Protobuf.Objects.TextPieceGift gift)
        {
            GiftId = gift?.GiftId ?? -1;
            NameRef = gift?.NameRef;
            ShowType = gift?.ShowType ?? GiftShowType.GiftShowDefault;
            ColorId = gift?.ColorId ?? -1;
        }

        public static implicit operator TextPieceGift(Models.Protobuf.Objects.TextPieceGift gift) => new TextPieceGift(gift);
    }
}