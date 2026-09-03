namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubscriptionGoalRecExtra
    {
        public readonly int SubscriptionCount;

        private SubscriptionGoalRecExtra(Models.Protobuf.Objects.SubscriptionGoalRecExtra extra)
        {
            SubscriptionCount = extra?.SubscriptionCount ?? -1;
        }

        public static implicit operator SubscriptionGoalRecExtra(Models.Protobuf.Objects.SubscriptionGoalRecExtra extra) => new SubscriptionGoalRecExtra(extra);
    }
}
