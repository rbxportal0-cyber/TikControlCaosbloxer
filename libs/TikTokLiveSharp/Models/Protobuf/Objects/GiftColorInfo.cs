using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftColorInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long ColorId { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ColorName { get; } = string.Empty;

        [ProtoMember(3)]
        public List<string> ColorValuesList { get; } = new List<string>();

        [ProtoMember(4)]
        public Image ColorImage { get; }

        [ProtoMember(5)]
        public Image GiftImage { get; }

        [ProtoMember(6)]
        public long ColorEffectId { get; }

        [ProtoMember(7)]
        public bool IsDefault { get; }
    }
}
