using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class TimestampContainer : AProtoBase
    {
        [ProtoMember(1)]
        public long Timestamp1 { get; }

        [ProtoMember(2)]
        public long Timestamp2 { get; }

        [ProtoMember(3)]
        public long Timestamp3 { get; }
    }
}
