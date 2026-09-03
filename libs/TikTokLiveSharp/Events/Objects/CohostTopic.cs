using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CohostTopic
    {
        public readonly long Id;
        public readonly string TitleKey;
        public readonly string TitleText;
        public readonly bool Liked;
        public readonly long TotalHeat;
        public readonly long TotalRivals;
        public readonly IReadOnlyList<Picture> RivalAvatars;

        private CohostTopic(Models.Protobuf.Objects.CohostTopic topic)
        {
            Id = topic?.Id ?? -1;
            TitleKey = topic?.TitleKey ?? string.Empty;
            TitleText = topic?.TitleText ?? string.Empty;
            Liked = topic?.Liked ?? false;
            TotalHeat = topic?.TotalHeat ?? -1;
            TotalRivals = topic?.TotalRivals ?? -1;
            RivalAvatars = topic?.RivalsAvatarList?.Count > 0 ? topic.RivalsAvatarList.Select(i => (Picture)i).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
        }

        public static implicit operator CohostTopic(Models.Protobuf.Objects.CohostTopic topic) => new CohostTopic(topic);
    }
}
