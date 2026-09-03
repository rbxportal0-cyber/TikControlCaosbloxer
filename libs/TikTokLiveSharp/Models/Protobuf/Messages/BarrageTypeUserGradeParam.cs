using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BarrageTypeUserGradeParam : AProtoBase
    {
        [ProtoMember(1)]
        public int CurrentGrade { get; }

        [ProtoMember(2)]
        public int DisplayConfig { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string UserId { get; } = string.Empty;

        [ProtoMember(4)]
        public User User { get; }
    }
}
