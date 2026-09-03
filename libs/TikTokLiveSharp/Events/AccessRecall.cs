using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class AccessRecall : AMessageData
    {
        public readonly int Status;
        public readonly long Duration;
        public readonly long EndTime;
        public readonly string Scene;
        public readonly Text Notice;
        public readonly Text Content;
        public readonly PunishEventInfo PunishInfo;

        internal AccessRecall(Models.Protobuf.Messages.AccessRecallMessage msg)
            : base(msg?.Header)
        {
            Status = msg?.Status ?? -1;
            Duration = msg?.Duration ?? -1;
            EndTime = msg?.EndTime ?? -1;
            Scene = msg?.Scene ?? string.Empty;
            Notice = msg?.Notice;
            Content = msg?.Content;
            PunishInfo = msg?.PunishInfo;
        }
    }
}