namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PerceptionFeedbackOption
    {
        public readonly long Id;
        public readonly string ContentKey;

        private PerceptionFeedbackOption(Models.Protobuf.Objects.PerceptionFeedbackOption option)
        {
            Id = option?.Id ?? -1;
            ContentKey = option?.ContentKey ?? string.Empty;
        }

        public static implicit operator PerceptionFeedbackOption(Models.Protobuf.Objects.PerceptionFeedbackOption option) => new PerceptionFeedbackOption(option);
    }
}
