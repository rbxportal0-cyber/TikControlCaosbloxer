using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkmicUserToastContent : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        public long RoomId { get; }

        [ProtoMember(3)]
        public Text DisplayText { get; }
    }
}
