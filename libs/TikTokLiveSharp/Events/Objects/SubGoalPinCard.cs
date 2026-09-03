namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubGoalPinCard
    {
        public readonly long GoalId;
        public readonly long TimeToLive;
        public readonly SubPinCardText Description;
        public readonly long Target;
        public readonly long Progress;

        private SubGoalPinCard(Models.Protobuf.Objects.SubGoalPinCard subGoalPinCard)
        {
            GoalId = subGoalPinCard?.GoalId ?? -1;
            TimeToLive = subGoalPinCard?.TimeToLive ?? -1;
            Description = subGoalPinCard?.Desc;
            Target = subGoalPinCard?.Target ?? -1;
            Progress = subGoalPinCard?.Progress ?? -1;
        }

        public static implicit operator SubGoalPinCard(Models.Protobuf.Objects.SubGoalPinCard subGoalPinCard) => new SubGoalPinCard(subGoalPinCard);
    }
}
