using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class WarningTag : AProtoBase
    {
        [ProtoMember(1)]
        public Text Text { get; }

        [ProtoMember(2)]
        public long Duration { get; }

        [ProtoMember(3)]
        public int TagSource { get; } // Possible Enum?

        [ProtoMember(4)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(5)]
        public int Style { get; } // Possible Enum?
        
        [ProtoMember(6)]
        [DefaultValue("")]
        public string DetailUrl { get; } = string.Empty;
    }
}
