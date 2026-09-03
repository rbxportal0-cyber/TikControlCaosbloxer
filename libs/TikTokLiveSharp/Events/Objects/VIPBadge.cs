using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class VIPBadge
    {
        public readonly IReadOnlyDictionary<long, Picture> IconsMap;

        private VIPBadge(Models.Protobuf.Objects.VIPBadge badge)
        {
            IconsMap = badge?.IconsMap?.Count > 0 ? new ReadOnlyDictionary<long, Picture>(badge.IconsMap.Select(i => new KeyValuePair<long,Picture>(i.Key, i.Value)).ToDictionary(i => i.Key, i => i.Value)) : new ReadOnlyDictionary<long, Picture>(new Dictionary<long, Picture>(0));
        }

        public static implicit operator VIPBadge(Models.Protobuf.Objects.VIPBadge badge) => new VIPBadge(badge);
    }
}
