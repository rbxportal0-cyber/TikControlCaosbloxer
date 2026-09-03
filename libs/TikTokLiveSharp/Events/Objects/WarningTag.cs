namespace TikTokLiveSharp.Events.Objects
{
    public sealed class WarningTag
    {
        public readonly Text Text;
        public readonly long Duration;
        public readonly int TagSource;
        public readonly PunishEventInfo PunishInfo;
        public readonly int Style;
        public readonly string DetailUrl;

        private WarningTag(Models.Protobuf.Objects.WarningTag tag)
        {
            Text = tag?.Text;
            Duration = tag?.Duration ?? -1;
            TagSource = tag?.TagSource ?? -1;
            PunishInfo = tag?.PunishInfo;
            Style = tag?.Style ?? -1;
            DetailUrl = tag?.DetailUrl ?? string.Empty;
        }

        public static implicit operator WarningTag(Models.Protobuf.Objects.WarningTag tag) => new WarningTag(tag);
    }
}
