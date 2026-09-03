namespace TikTokLiveSharp.Events
{
    public sealed class BindingGift : AMessageData
    {
        public readonly GiftMessage Message;

        internal BindingGift(Models.Protobuf.Messages.BindingGiftMessage msg)
            : base(msg?.Header)
        {
            Message = new GiftMessage(msg?.Message);
        }
    }
}