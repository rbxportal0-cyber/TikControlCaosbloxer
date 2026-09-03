namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LiveMessageSEI
    {
        public readonly LiveMessageID UniqueId;
        public readonly long Timestamp;

        private LiveMessageSEI(Models.Protobuf.Objects.LiveMessageSEI sei)
        {
            UniqueId = sei?.UniqueId;
            Timestamp = sei?.Timestamp ?? -1;
        }

        public static implicit operator LiveMessageSEI(Models.Protobuf.Objects.LiveMessageSEI sei) => new LiveMessageSEI(sei);
    }
}
