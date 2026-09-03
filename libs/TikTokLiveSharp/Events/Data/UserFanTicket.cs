namespace TikTokLiveSharp.Events.Data
{
    public sealed class UserFanTicket
    {
        public readonly long UserId;
        public readonly long FanTicket;
        public readonly long MatchTotalScore;
        public readonly int MatchRank;

        private UserFanTicket(Models.Protobuf.Messages.UserFanTicket ticket)
        {
            UserId = ticket?.UserId ?? -1;
            FanTicket = ticket?.FanTicket ?? -1;
            MatchTotalScore = ticket?.MatchTotalScore ?? -1;
            MatchRank = ticket?.MatchRank ?? -1;
        }

        public static implicit operator UserFanTicket(Models.Protobuf.Messages.UserFanTicket ticket) => new UserFanTicket(ticket);
    }
}
