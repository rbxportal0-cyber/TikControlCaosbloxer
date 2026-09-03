using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class FontStyle : AProtoBase
    {
        [ProtoMember(1)]
        public int FontSize { get; }

        [ProtoMember(2)]
        public int FontWidth { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string FontColor { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string BorderColor { get; } = string.Empty;
    }
}
