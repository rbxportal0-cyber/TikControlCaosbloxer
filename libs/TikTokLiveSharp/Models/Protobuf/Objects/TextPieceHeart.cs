using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPieceHeart : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Color { get; } = string.Empty;
    }
}
