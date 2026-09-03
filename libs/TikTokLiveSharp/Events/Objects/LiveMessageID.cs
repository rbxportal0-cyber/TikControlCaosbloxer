namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LiveMessageID
    {
        public readonly string PrimaryId;
        public readonly string MessageScene;

        private LiveMessageID(Models.Protobuf.Objects.LiveMessageID id)
        {
            PrimaryId = id?.PrimaryId ?? string.Empty;
            MessageScene = id?.MessageScene ?? string.Empty;
        }

        public static implicit operator LiveMessageID(Models.Protobuf.Objects.LiveMessageID id) => new LiveMessageID(id);
    }
}
