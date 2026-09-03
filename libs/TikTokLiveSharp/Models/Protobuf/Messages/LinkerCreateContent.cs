using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerCreateContent : AProtoBase
    {
        [ProtoMember(1)]
        public long OwnerId { get; }

        [ProtoMember(2)]
        public long OwnerRoomId { get; }

        [ProtoMember(3)]
        public long LinkType { get; }
    }
}
