namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class TimestampContainer
    {
        public readonly long Timestamp1;
        public readonly long Timestamp2;
        public readonly long Timestamp3;

        private TimestampContainer(Models.Protobuf.UnknownObjects.Data.TimestampContainer ts)
        {
            Timestamp1 = ts?.Timestamp1 ?? -1;
            Timestamp2 = ts?.Timestamp2 ?? -1;
            Timestamp3 = ts?.Timestamp3 ?? -1;
        }

        public static implicit operator TimestampContainer(Models.Protobuf.UnknownObjects.Data.TimestampContainer ts) => new TimestampContainer(ts);
    }
}
