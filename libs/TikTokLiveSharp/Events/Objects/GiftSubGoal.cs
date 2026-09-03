namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftSubGoal
    {
        public readonly string Name;
        public readonly Picture Icon;
        public readonly long DiamondCount;
        public readonly int Type;

        private GiftSubGoal(Models.Protobuf.Objects.GiftSubGoal goal)
        {
            Name = goal?.Name ?? string.Empty;
            Icon = goal?.Icon;
            DiamondCount = goal?.DiamondCount ?? -1;
            Type = goal?.Type ?? -1;
        }

        public static implicit operator GiftSubGoal(Models.Protobuf.Objects.GiftSubGoal goal) => new GiftSubGoal(goal);
    }
}
