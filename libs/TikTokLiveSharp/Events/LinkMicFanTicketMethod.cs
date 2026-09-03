using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events
{
    public sealed class LinkMicFanTicketMethod : AMessageData
    {
        public readonly FanTicketRoomNoticeContent Content;

        internal LinkMicFanTicketMethod(Models.Protobuf.Messages.LinkMicFanTicketMethod msg)
            : base(msg?.Header)
        {
            Content = msg?.FanTicketRoomNotice;
        }
    }
}