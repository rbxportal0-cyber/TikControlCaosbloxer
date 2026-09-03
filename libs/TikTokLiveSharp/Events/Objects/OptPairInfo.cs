using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class OptPairInfo
    {
        public readonly long MappingId;
        public readonly long ExpectedTimeSec;
        public readonly OptPairStatus OptPairStatus;

        private OptPairInfo(Models.Protobuf.Objects.OptPairInfo info)
        {
            MappingId = info?.MappingId ?? -1;
            ExpectedTimeSec = info?.ExpectedTimeSec ?? -1;
            OptPairStatus = info?.OptPairStatus ?? OptPairStatus.Opt_Pair_Status_Unknown;
        }

        public static implicit operator OptPairInfo(Models.Protobuf.Objects.OptPairInfo info) => new OptPairInfo(info);
    }
}
