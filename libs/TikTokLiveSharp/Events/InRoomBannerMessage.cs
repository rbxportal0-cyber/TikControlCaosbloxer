namespace TikTokLiveSharp.Events
{
    public sealed class InRoomBannerMessage : AMessageData
    {
        public readonly string JsonData;
        public readonly int Position;
        public readonly int ActionType;

        internal InRoomBannerMessage(Models.Protobuf.Messages.InRoomBannerMessage msg)
            : base(msg?.Header)
        {
            JsonData = msg?.Extra ?? string.Empty;
            Position = msg?.Position ?? -1;
            ActionType = msg?.ActionType ?? -1;
        }
    }
}