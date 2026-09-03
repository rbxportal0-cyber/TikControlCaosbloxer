using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ShowInfo
    {
        public readonly long ShowStartTime;
        public readonly long ShowEndTime;
        public readonly IReadOnlyList<User> Anchors;
        public readonly string ShowIntroduction;

        private ShowInfo(Models.Protobuf.Objects.ShowInfo info)
        {
            ShowStartTime = info?.ShowStartTime ?? -1;
            ShowEndTime = info?.ShowEndTime ?? -1;
            Anchors = info?.Anchors?.Count > 0 ? info.Anchors.Select(u => (User)u).ToList().AsReadOnly() : new List<User>(0).AsReadOnly();
            ShowIntroduction = info?.ShowIntroduction ?? string.Empty;
        }

        public static implicit operator ShowInfo(Models.Protobuf.Objects.ShowInfo info) => new ShowInfo(info);
    }
}
