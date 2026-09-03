using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubCustomizedBenefitEntrance
    {
        public readonly bool ShowEntrance;
        public readonly AuditStatus LastAuditStatus;
        public readonly long LastBenefitId;
        public readonly long Figures;
        public readonly IReadOnlyList<Perk> EnabledPerksList;
        public readonly long MaxPerksCount;

        private SubCustomizedBenefitEntrance(Models.Protobuf.Objects.SubCustomizedBenefitEntrance entrance)
        {
            ShowEntrance = entrance?.ShowEntrance ?? false;
            LastAuditStatus = entrance?.LastAuditStatus ?? AuditStatus.AuditStatusUnknown;
            LastBenefitId = entrance?.LastBenefitId ?? -1;
            Figures = entrance?.Figures ?? -1;
            EnabledPerksList = entrance?.EnabledPerksList?.Count > 0 ? entrance.EnabledPerksList.Select(p => (Perk)p).ToList().AsReadOnly() : new List<Perk>(0).AsReadOnly();
            MaxPerksCount = entrance?.MaxPerksCnt ?? -1;
        }

        public static implicit operator SubCustomizedBenefitEntrance(Models.Protobuf.Objects.SubCustomizedBenefitEntrance entrance) => new SubCustomizedBenefitEntrance(entrance);
    }
}
