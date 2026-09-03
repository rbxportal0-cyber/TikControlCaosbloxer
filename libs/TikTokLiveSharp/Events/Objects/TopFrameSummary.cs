using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TopFrameSummary
    {
        public readonly long Id;
        public readonly string Title;
        public readonly string Schema;
        public readonly IReadOnlyList<ShowInfo> ShowList;

        private TopFrameSummary(Models.Protobuf.Objects.TopFrameSummary summary)
        {
            Id = summary?.Id ?? -1;
            Title = summary?.Title ?? string.Empty;
            Schema = summary?.Schema ?? string.Empty;
            ShowList = summary?.ShowList?.Count > 0 ? summary.ShowList.Select(i => (ShowInfo)i).ToList().AsReadOnly() : new List<ShowInfo>(0).AsReadOnly();
        }

        public static implicit operator TopFrameSummary(Models.Protobuf.Objects.TopFrameSummary summary) => new TopFrameSummary(summary);
    }
}
