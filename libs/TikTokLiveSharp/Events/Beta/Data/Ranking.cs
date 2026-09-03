using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class Ranking
    {
        public readonly string Type;
        public readonly string Label;
        public readonly Text Text;
        public readonly IReadOnlyList<ValueLabel> Details;

        private Ranking(Models.Protobuf.UnknownObjects.Data.Ranking ranking)
        {
            Type = ranking?.Type ?? string.Empty;
            Label = ranking?.Label ?? string.Empty;
            Text = ranking?.Text;
            Details = ranking?.Details?.Count > 0 ? ranking.Details.Select(v => (ValueLabel)v).ToList().AsReadOnly() : new List<ValueLabel>(0).AsReadOnly();
        }

        public static implicit operator Ranking(Models.Protobuf.UnknownObjects.Data.Ranking ranking) => new Ranking(ranking);
    }
}
