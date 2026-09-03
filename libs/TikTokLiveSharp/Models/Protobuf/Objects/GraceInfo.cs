using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GraceInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsInGracePeriod { get; }

        [ProtoMember(2)]
        public long GraceEndTime { get; }
    }
}
