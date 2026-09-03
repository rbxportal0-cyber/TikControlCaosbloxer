using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextPiecePatternRef : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string DefaultPattern { get; } = string.Empty;
    }
}
