namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftInCart
    {
        public readonly long GiftId;
        public readonly long ColorId;

        private GiftInCart(Models.Protobuf.Objects.GiftInCart giftInCart)
        {
            GiftId = giftInCart?.GiftId ?? -1;
            ColorId = giftInCart?.ColorId ?? -1;
        }

        public static implicit operator GiftInCart(Models.Protobuf.Objects.GiftInCart giftInCart) => new GiftInCart(giftInCart);
    }
}
