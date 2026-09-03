using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class Player : AProtoBase
    {
        [ProtoMember(1)]
        public long RoomId { get; }

        [ProtoMember(2)]
        public long UserId { get; }
    }
}
