using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerAcceptNoticeContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public long FromRoomId { get; }

        [ProtoMember(3)]
        public long ToUserId { get; }
    }
}
