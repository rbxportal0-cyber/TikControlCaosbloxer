using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubCustomizedBenefitEntrance : AProtoBase
    {
        [ProtoMember(1)]
        public bool ShowEntrance { get; }

        [ProtoMember(2)]
        public AuditStatus LastAuditStatus { get; }

        [ProtoMember(3)]
        public long LastBenefitId { get; }

        [ProtoMember(4)]
        public long Figures { get; }

        [ProtoMember(5)]
        public List<Perk> EnabledPerksList { get; } = new List<Perk>();

        [ProtoMember(6)]
        public long MaxPerksCnt { get; }
    }
}
