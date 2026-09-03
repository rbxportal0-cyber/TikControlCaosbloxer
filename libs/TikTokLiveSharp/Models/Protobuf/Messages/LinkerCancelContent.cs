using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerCancelContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public long ToUserId { get; }

        [ProtoMember(3)]
        public long CancelType { get; }

        [ProtoMember(4)]
        public long ActionId { get; }
    }
}
