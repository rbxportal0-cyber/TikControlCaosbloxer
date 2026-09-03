using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPieceUser : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; }

        [ProtoMember(2)]
        public bool WithColon { get; }
    }
}
