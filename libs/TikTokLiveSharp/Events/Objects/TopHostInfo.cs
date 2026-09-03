namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TopHostInfo
    {
        public readonly string RankType;
        public readonly long TopIndex;

        private TopHostInfo(Models.Protobuf.Objects.TopHostInfo topHostInfo)
        {
            RankType = topHostInfo?.RankType ?? string.Empty;
            TopIndex = topHostInfo?.TopIndex ?? -1;
        }

        public static implicit operator TopHostInfo(Models.Protobuf.Objects.TopHostInfo topHostInfo) => new TopHostInfo(topHostInfo);
    }
}
