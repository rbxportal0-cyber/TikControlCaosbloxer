namespace TikTokLiveSharp.Events.Objects
{
    public sealed class EventCard
    {
        public readonly LiveEventInfo Event;
        public readonly long CardStartTime;
        public readonly string CardIconUrl;

        private EventCard(Models.Protobuf.Objects.EventCard card)
        {
            Event = card?.Event;
            CardStartTime = card?.CardStartTime ?? -1;
            CardIconUrl = card?.CardIconUrl ?? string.Empty;
        }

        public static implicit operator EventCard(Models.Protobuf.Objects.EventCard card) => new EventCard(card);
    }
}
