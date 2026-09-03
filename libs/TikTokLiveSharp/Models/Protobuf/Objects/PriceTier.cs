using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PriceTier : AProtoBase
    {
        [ProtoMember(1)]
        public long PriceTierGrade { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string USDPrice { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string LocalPrice { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string PriceHint { get; } = string.Empty;

        [ProtoMember(5)]
        public bool IsDefault { get; }
    }
}
