using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class EmoteDetail
    {
        public readonly IReadOnlyList<Emote> Emotes;
        public readonly bool Exist;
        public readonly long EmoteVersion;

        private EmoteDetail(Models.Protobuf.Objects.EmoteDetail detail)
        {
            Emotes = detail?.EmoteList?.Count > 0 ? detail.EmoteList.Select(e => (Emote)e).ToList().AsReadOnly() : new List<Emote>(0).AsReadOnly();
            Exist = detail?.Exist ?? false;
            EmoteVersion = detail?.EmoteVersion ?? -1;
        }

        public static implicit operator EmoteDetail(Models.Protobuf.Objects.EmoteDetail detail) => new EmoteDetail(detail);
    }
}
