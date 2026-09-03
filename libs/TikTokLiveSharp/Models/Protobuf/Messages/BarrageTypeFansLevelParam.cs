using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BarrageTypeFansLevelParam : AProtoBase
    {
        [ProtoMember(1)]
        public int CurrentGrade { get; }

        [ProtoMember(2)]
        public int DisplayConfig { get; }

        [ProtoMember(3)]
        public User User { get; }
    }
}
