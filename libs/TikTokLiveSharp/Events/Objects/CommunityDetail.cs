using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CommunityDetail
    {
        public readonly IReadOnlyList<CommunityContent> CommunityContent;
        public readonly AuditStatus AuditStatus;

        private CommunityDetail(Models.Protobuf.Objects.CommunityDetail communityDetail)
        {
            CommunityContent = communityDetail?.CommunityContentList?.Count > 0 ? communityDetail.CommunityContentList.Select(c => (CommunityContent)c).ToList().AsReadOnly() : new List<CommunityContent>(0).AsReadOnly();
            AuditStatus = communityDetail?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
        }

        public static implicit operator CommunityDetail(Models.Protobuf.Objects.CommunityDetail communityDetail) => new CommunityDetail(communityDetail);
    }
}
