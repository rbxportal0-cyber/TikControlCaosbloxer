using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LiveMessageSEI : AProtoBase
    {
        [ProtoMember(1)]
        public LiveMessageID UniqueId { get; }

        [ProtoMember(2)]
        public long Timestamp { get; }
    }
}
