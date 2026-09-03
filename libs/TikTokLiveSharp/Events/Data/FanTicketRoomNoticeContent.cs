using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class FanTicketRoomNoticeContent
    {
        public readonly IReadOnlyList<UserFanTicket> UserFanTickets;
        public readonly long TotalLinkMicFanTicket;
        public readonly long MatchId;
        public readonly long EventTime;
        public readonly string FanTicketIconUrl;

        private FanTicketRoomNoticeContent(Models.Protobuf.Messages.FanTicketRoomNoticeContent content)
        {
            UserFanTickets = content?.UserFanTicketList?.Count > 0 ? content.UserFanTicketList.Select(t => (UserFanTicket)t).ToList().AsReadOnly() : new List<UserFanTicket>(0).AsReadOnly();
            TotalLinkMicFanTicket = content?.TotalLinkMicFanTicket ?? -1;
            MatchId = content?.MatchId ?? -1;
            EventTime = content?.EventTime ?? -1;
            FanTicketIconUrl = content?.FanTicketIconUrl ?? string.Empty;
        }

        public static implicit operator FanTicketRoomNoticeContent(Models.Protobuf.Messages.FanTicketRoomNoticeContent content) => new FanTicketRoomNoticeContent(content);
    }
}
