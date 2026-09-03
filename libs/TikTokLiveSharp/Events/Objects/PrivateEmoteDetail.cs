using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PrivateEmoteDetail
    {
        public readonly IReadOnlyList<Emote> Emotes;

        private PrivateEmoteDetail(Models.Protobuf.Objects.PrivateEmoteDetail detail)
        {
            Emotes = detail?.EmoteList?.Count > 0 ? detail.EmoteList.Select(e => (Emote)e).ToList().AsReadOnly() : new List<Emote>(0).AsReadOnly();
        }

        public static implicit operator PrivateEmoteDetail(Models.Protobuf.Objects.PrivateEmoteDetail detail) => new PrivateEmoteDetail(detail);
    }
}
