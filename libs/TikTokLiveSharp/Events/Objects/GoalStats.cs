namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GoalStats
    {
        public readonly long TotalCoins;
        public readonly long TotalContributor;
        public readonly GoalComparison Comparison;

        private GoalStats(Models.Protobuf.Objects.GoalStats stats)
        {
            TotalCoins = stats?.TotalCoins ?? -1;
            TotalContributor = stats?.TotalContributor ?? -1;
            Comparison = stats?.Comparison;
        }

        public static implicit operator GoalStats(Models.Protobuf.Objects.GoalStats stats) => new GoalStats(stats);
    }
}
