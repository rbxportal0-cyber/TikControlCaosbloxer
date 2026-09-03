using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class EmoteConfig
    {
        public readonly int EmoteCountLimit;
        public readonly IReadOnlyList<Emote> DefaultEmotes;

        private EmoteConfig(Models.Protobuf.Objects.EmoteConfig config)
        {
            EmoteCountLimit = config?.EmoteCntLmt ?? -1;
            DefaultEmotes = config?.DefaultEmoteList?.Count > 0 ? config.DefaultEmoteList.Select(e => (Emote)e).ToList().AsReadOnly() : new List<Emote>(0).AsReadOnly();
        }

        public static implicit operator EmoteConfig(Models.Protobuf.Objects.EmoteConfig config) => new EmoteConfig(config);
    }
}
