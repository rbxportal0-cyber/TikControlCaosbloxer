using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PriceChangeInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsPriceChanged { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string NewPrice { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string OldPrice { get; } = string.Empty;

        [ProtoMember(4)]
        public long NextBillingDate { get; }

        [ProtoMember(6)]
        public long DaysLeftToAgreeChange { get; }

        [ProtoMember(7)]
        public bool IsFirstEntrance { get; }

        [ProtoMember(8)]
        public bool IsConsentRequired { get; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string ContractId { get; } = string.Empty;

        [ProtoMember(10)]
        [DefaultValue("")]
        public string OrderId { get; } = string.Empty;

        [ProtoMember(11)]
        public long NoConfirmCancelContractDate { get; }
    }
}
