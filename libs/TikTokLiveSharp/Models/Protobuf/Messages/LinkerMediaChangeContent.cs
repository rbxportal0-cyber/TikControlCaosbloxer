using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerMediaChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public MicIdxOperation Op { get; }

        [ProtoMember(2)]
        public long ToUserId { get; }

        [ProtoMember(3)]
        public long AnchorId { get; }

        [ProtoMember(4)]
        public long RoomId { get; }

        [ProtoMember(5)]
        public LinkerSceneType ChangeScene { get; }
    }
}
