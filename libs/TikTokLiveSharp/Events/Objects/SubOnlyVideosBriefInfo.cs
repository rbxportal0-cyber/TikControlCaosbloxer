using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubOnlyVideosBriefInfo
    {
        public readonly string TotalCountString;
        public readonly int TotalCount;
        public readonly IReadOnlyList<SOVBriefInfo> SOVBriefInfoList;

        private SubOnlyVideosBriefInfo(Models.Protobuf.Objects.SubOnlyVideosBriefInfo info)
        {
            TotalCountString = info?.TotalCountStr ?? string.Empty;
            TotalCount = info?.TotalCount ?? -1;
            SOVBriefInfoList = info?.SOVBriefInfoList?.Count > 0 ? info.SOVBriefInfoList.Select(i => (SOVBriefInfo)i).ToList().AsReadOnly() : new List<SOVBriefInfo>(0).AsReadOnly();
        }

        public static implicit operator SubOnlyVideosBriefInfo(Models.Protobuf.Objects.SubOnlyVideosBriefInfo info) => new SubOnlyVideosBriefInfo(info);
    }
}
