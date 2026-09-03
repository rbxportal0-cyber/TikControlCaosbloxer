using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SpotlightInfo
    {
        public readonly IReadOnlyList<SpotlightItem> Items;

        private SpotlightInfo(Models.Protobuf.Objects.SpotlightInfo info)
        {
            Items = info?.ItemList?.Count > 0 ? info.ItemList.Select(i => (SpotlightItem)i).ToList().AsReadOnly() : new List<SpotlightItem>(0).AsReadOnly();
        }

        public static implicit operator SpotlightInfo(Models.Protobuf.Objects.SpotlightInfo info) => new SpotlightInfo(info);
    }
}
