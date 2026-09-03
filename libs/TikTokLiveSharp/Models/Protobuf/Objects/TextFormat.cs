using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextFormat : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Color { get; } = string.Empty;

        [ProtoMember(2)]
        public bool Bold { get; }

        [ProtoMember(3)]
        public bool Italic { get; }

        [ProtoMember(4)]
        public int Weight { get; }

        [ProtoMember(5)]
        public int ItalicAngle { get; }

        [ProtoMember(6)]
        public int FontSize { get; }

        [ProtoMember(7)]
        public bool UseHeighLightColor { get; } // Typo exists in TikTok's Code

        [ProtoMember(8)]
        public bool UseRemoteClor { get; } // Typo exists in TikTok's Code
    }
}
