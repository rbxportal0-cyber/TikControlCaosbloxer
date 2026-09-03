namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubLevel
    {
        public readonly int Level;
        public readonly string Description;
        public readonly int MonthLimit;
        public readonly LevelBadge Level_Badge;
        public readonly Badge Badge;

        private SubLevel(Models.Protobuf.Objects.SubLevel subLevel)
        {
            Level = subLevel?.Level ?? -1;
            Description = subLevel?.Desc ?? string.Empty;
            MonthLimit = subLevel?.MonthLimit ?? -1;
            Level_Badge = subLevel?.Badge;
            Badge = subLevel?.BadgeStruct;
        }

        public static implicit operator SubLevel(Models.Protobuf.Objects.SubLevel subLevel) => new SubLevel(subLevel);
    }
}
