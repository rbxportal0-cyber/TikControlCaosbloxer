namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubStatisticsData
    {
        public readonly long FirstSubStartTime;
        public readonly long FirstSubEndTime;
        public readonly long LastSubStartTime;
        public readonly long LastSubEndTime;
        public readonly int ActiveSubscribeDays;

        private SubStatisticsData(Models.Protobuf.Objects.SubStatisticsData data)
        {
            FirstSubStartTime = data?.FirstSubStartTime ?? -1;
            FirstSubEndTime = data?.FirstSubEndTime ?? -1;
            LastSubStartTime = data?.LastSubStartTime ?? -1;
            LastSubEndTime = data?.LastSubEndTime ?? -1;
            ActiveSubscribeDays = data?.ActiveSubscribeDays ?? -1;
        }

        public static implicit operator SubStatisticsData(Models.Protobuf.Objects.SubStatisticsData data) => new SubStatisticsData(data);
    }
}
