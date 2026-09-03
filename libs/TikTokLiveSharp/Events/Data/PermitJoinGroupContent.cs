using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PermitJoinGroupContent
    {
        public readonly GroupPlayer Approver;
        public readonly AgreeStatus AgreeStatus;
        public readonly JoinType Type;
        public readonly IReadOnlyList<RTCExtraInfo> GroupExtInfos;
        public readonly GroupChannelAllUser GroupUser;

        private PermitJoinGroupContent(Models.Protobuf.Messages.PermitJoinGroupContent content)
        {
            Approver = content?.Approver;
            AgreeStatus = content?.AgreeStatus ?? AgreeStatus.Agree_Unknown;
            Type = content?.Type ?? JoinType.Join_Type_Unknown;
            GroupExtInfos = content?.GroupExtInfoList?.Count > 0 ? content.GroupExtInfoList.Select(i => (RTCExtraInfo)i).ToList().AsReadOnly() : new List<RTCExtraInfo>(0).AsReadOnly();
            GroupUser = content?.GroupUser;
        }

        public static implicit operator PermitJoinGroupContent(Models.Protobuf.Messages.PermitJoinGroupContent content) => new PermitJoinGroupContent(content);
    }
}
