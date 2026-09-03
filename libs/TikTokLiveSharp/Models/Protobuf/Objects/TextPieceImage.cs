using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPieceImage : AProtoBase
    {
        [ProtoMember(1)]
        public Image Image { get; }
    }
}
