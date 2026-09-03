namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GoalComparison
    {
        public readonly long CoinsIncr;
        public readonly long ContributorIncr;

        private GoalComparison(Models.Protobuf.Objects.GoalComparison comparison)
        {
            CoinsIncr = comparison?.CoinsIncr ?? -1;
            ContributorIncr = comparison?.ContributorIncr ?? -1;
        }

        public static implicit operator GoalComparison(Models.Protobuf.Objects.GoalComparison comparison) => new GoalComparison(comparison);
    }
}
