using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPiece : AProtoBase
    {
        [ProtoMember(1)]
        public int Type { get; }

        [ProtoMember(2)]
        public TextFormat Format { get; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string StringValue { get; } = string.Empty;

        [ProtoMember(21)]
        public TextPieceUser UserValue { get; }

        [ProtoMember(22)]
        public TextPieceGift GiftValue { get; }

        [ProtoMember(23)]
        public TextPieceHeart HeartValue { get; }

        [ProtoMember(24)]
        public TextPiecePatternRef PatternRefValue { get; }

        [ProtoMember(25)]
        public TextPieceImage ImageValue { get; }
    }
}
