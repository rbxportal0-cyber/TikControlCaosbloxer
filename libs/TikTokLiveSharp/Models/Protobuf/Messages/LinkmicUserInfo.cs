using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkmicUserInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;

        [ProtoMember(3)]
        public long RoomId { get; }

        [ProtoMember(4)]
        public long LinkedTime { get; }
    }
}
