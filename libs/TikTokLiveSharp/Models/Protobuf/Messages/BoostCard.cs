using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BoostCard : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public int TaskSource { get; }

        [ProtoMember(3)]
        public long TaskId { get; }
    }
}
