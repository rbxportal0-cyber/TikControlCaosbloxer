using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubGoal
    {
        public readonly SubGoalType Type;
        public readonly long Id;
        public readonly long Progress;
        public readonly long Target;
        public readonly GiftSubGoal Gift;
        public readonly string IdStr;

        private SubGoal(Models.Protobuf.Objects.SubGoal goal)
        {
            Type = goal?.Type ?? SubGoalType.SubGoalTypeUnknown;
            Id = goal?.Id ?? -1;
            Progress = goal?.Progress ?? -1;
            Target = goal?.Target ?? -1;
            Gift = goal?.Gift;
            IdStr = goal?.IdStr ?? string.Empty;
        }

        public static implicit operator SubGoal(Models.Protobuf.Objects.SubGoal info) => new SubGoal(info);
    }
}
