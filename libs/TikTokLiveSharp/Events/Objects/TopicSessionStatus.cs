namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TopicSessionStatus
    {
        public readonly long SessionId;
        public readonly long SessionHeat;

        private TopicSessionStatus(Models.Protobuf.Objects.TopicSessionStatus sessionStatus)
        {
            SessionId = sessionStatus?.SessionId ?? -1;
            SessionHeat = sessionStatus?.SessionHeat ?? -1;
        }

        public static implicit operator TopicSessionStatus(Models.Protobuf.Objects.TopicSessionStatus sessionStatus) =>
            new TopicSessionStatus(sessionStatus);
    }
}
