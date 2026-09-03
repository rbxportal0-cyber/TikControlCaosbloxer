using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Message containing RoomInfo, sent regularly by server
    /// </summary>
    public sealed class RoomUpdate : AMessageData
    {
        /// <summary>
        /// Number of Viewers currently in Room
        /// </summary>
        public readonly long NumberOfViewers;
        /// <summary>
        /// Popularity of Room, as determined by TikTok
        /// </summary>
        public readonly long Popularity;
        public readonly long TotalUsers;
        /// <summary>
        /// Top Viewers in Room (based on number of Coins given)
        /// </summary>
        public readonly IReadOnlyList<TopViewer> TopViewers;
        public readonly IReadOnlyList<TopViewer> Seats;

        public readonly string PopStr;
        public readonly long Anonymous;
        
        internal RoomUpdate(Models.Protobuf.Messages.RoomUserSeqMessage msg)
            : base(msg?.Header)
        {
            NumberOfViewers = msg?.Total ?? -1;
            Popularity = msg?.Popularity ?? -1;
            TotalUsers = msg?.TotalUser ?? -1;
            TopViewers = msg?.RanksList?.Count > 0 ? msg.RanksList.OrderBy(u => u.Rank).Select(u => (TopViewer)u).ToList() : new List<TopViewer>(0);
            Seats = msg?.SeatsList?.Count > 0 ? msg.SeatsList.OrderBy(u => u.Rank).Select(u => (TopViewer)u).ToList() : new List<TopViewer>(0);
            PopStr = msg?.PopStr ?? string.Empty;
            Anonymous = msg?.Anonymous ?? -1;
        }
    }
}