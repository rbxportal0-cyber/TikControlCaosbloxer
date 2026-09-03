using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TopicSessionStatus : AProtoBase
    {
        [ProtoMember(1)]
        public long SessionId { get; }

        [ProtoMember(2)]
        public long SessionHeat { get; }
    }
}
