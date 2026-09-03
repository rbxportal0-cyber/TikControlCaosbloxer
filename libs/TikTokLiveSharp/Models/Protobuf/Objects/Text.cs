using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Text : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string DefaultPattern { get; } = string.Empty;

        [ProtoMember(3)]
        public TextFormat DefaultFormat { get; }

        [ProtoMember(4)]
        public List<TextPiece> PiecesList { get; } = new List<TextPiece>();
    }
}
