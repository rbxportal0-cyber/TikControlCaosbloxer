using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubStatisticsData : AProtoBase
    {
        [ProtoMember(1)]
        public long FirstSubStartTime { get; }

        [ProtoMember(2)]
        public long FirstSubEndTime { get; }

        [ProtoMember(3)]
        public long LastSubStartTime { get; }

        [ProtoMember(4)]
        public long LastSubEndTime { get; }

        [ProtoMember(5)]
        public int ActiveSubscribeDays { get; }
    }
}
