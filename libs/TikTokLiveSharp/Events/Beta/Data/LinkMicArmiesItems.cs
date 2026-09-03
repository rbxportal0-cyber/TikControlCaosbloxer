using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class LinkMicArmiesItems
    {
        public readonly ulong HostUserId;
        public readonly IReadOnlyList<LinkMicArmy> BattleGroups;

        private LinkMicArmiesItems(Models.Protobuf.UnknownObjects.Data.LinkMicArmiesItems items)
        {
            HostUserId = items?.HostUserId ?? 0;
            BattleGroups = items?.BattleGroups?.Count > 0 ? items.BattleGroups.Select(a => (LinkMicArmy)a).ToList().AsReadOnly() : new List<LinkMicArmy>(0).AsReadOnly();
        }

        public static implicit operator LinkMicArmiesItems(Models.Protobuf.UnknownObjects.Data.LinkMicArmiesItems items) => new LinkMicArmiesItems(items);
    }
}
