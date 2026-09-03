namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkMicAdContent
    {
        public readonly long RoomId;
        public readonly long AdId;
        public readonly long Duration;
        public readonly long PlayTimes;
        public readonly string Url;

        private LinkMicAdContent(Models.Protobuf.LinkmicCommon.LinkMicAdContent content)
        {
            RoomId = content?.RoomId ?? -1;
            AdId = content?.AdId ?? -1;
            Duration = content?.Duration ?? -1;
            PlayTimes = content?.PlayTimes ?? -1;
            Url = content?.Url ?? string.Empty;
        }

        public static implicit operator LinkMicAdContent(Models.Protobuf.LinkmicCommon.LinkMicAdContent content) => new LinkMicAdContent(content);
    }
}
