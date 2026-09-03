namespace TikTokLiveSharp.Events.Objects
{
    public sealed class StreamGoalRecExtra
    {
        public readonly string LeadText;

        private StreamGoalRecExtra(Models.Protobuf.Objects.StreamGoalRecExtra extra)
        {
            LeadText = extra?.LeadText ?? string.Empty;
        }

        public static implicit operator StreamGoalRecExtra(Models.Protobuf.Objects.StreamGoalRecExtra extra) => new StreamGoalRecExtra(extra);
    }
}
