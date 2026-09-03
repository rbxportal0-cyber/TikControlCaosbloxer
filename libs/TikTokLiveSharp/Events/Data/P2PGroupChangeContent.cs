using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class P2PGroupChangeContent
    {
        public readonly IReadOnlyList<RTCExtraInfo> GroupExtInfoList;
        public readonly GroupChannelAllUser GroupUser;

        private P2PGroupChangeContent(Models.Protobuf.Messages.P2PGroupChangeContent content)
        {
            GroupExtInfoList = content?.GroupExtInfoList?.Count > 0 ? content.GroupExtInfoList.Select(i => (RTCExtraInfo)i).ToList().AsReadOnly() : new List<RTCExtraInfo>(0).AsReadOnly();
        }

        public static implicit operator P2PGroupChangeContent(Models.Protobuf.Messages.P2PGroupChangeContent content) => new P2PGroupChangeContent(content);
    }
}
