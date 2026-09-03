namespace TikTokLiveSharp.Events
{
    public sealed class GiftPrompt : AMessageData
    {
        public readonly string Title;
        public readonly string Body;
        public readonly int BlockNumDays;
        public readonly string OrderId;
        public readonly long OrderTimestamp;

        internal GiftPrompt(Models.Protobuf.Messages.GiftPromptMessage msg)
            : base(msg?.Header)
        {
            Title = msg?.Title ?? string.Empty;
            Body = msg?.Body ?? string.Empty;
            BlockNumDays = msg?.BlockNumDays ?? -1;
            OrderId = msg?.OrderId ?? string.Empty;
            OrderTimestamp = msg?.OrderTimestamp ?? -1;
        }
    }
}