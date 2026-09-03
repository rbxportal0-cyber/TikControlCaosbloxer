namespace TikTokLiveSharp.Events
{
    public sealed class RoomVerify : AMessageData
    {
        public readonly int Action;
        public readonly string Content;
        public readonly long NoticeType;
        public readonly bool CloseRoom;

        internal RoomVerify(Models.Protobuf.Messages.RoomVerifyMessage msg)
            : base(msg?.Header)
        {
            Action = msg?.Action ?? -1;
            Content = msg?.Content ?? string.Empty;
            NoticeType = msg?.NoticeType ?? -1;
            CloseRoom = msg?.CloseRoom ?? false;
        }
    }
}