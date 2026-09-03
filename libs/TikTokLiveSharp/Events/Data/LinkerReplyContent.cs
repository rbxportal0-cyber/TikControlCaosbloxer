using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerReplyContent
    {
        public readonly long FromUserId;
        public readonly long FromRoomId;
        public readonly LinkmicInfo FromUserLinkmicInfo;
        public readonly long ToUserId;
        public readonly LinkmicInfo ToUserLinkmicInfo;
        public readonly long LinkType;
        public readonly long ReplyStatus;
        public readonly LinkerSetting LinkerSetting;
        public readonly User FromUser;
        public readonly User ToUser;
        public readonly IReadOnlyDictionary<long, string> RtcExtInfos;
        public readonly LinkerMicIdxUpdateInfo InviteeMicIdxUpdateInfo;
        public readonly IReadOnlyDictionary<long, long> ApplierMicIdxInfoMap;
        public readonly LinkmicMultiLiveEnum HostMultiLiveEnum;
        public readonly LinkmicUserSettingInfo HostSettingInfo;
        public readonly long ActionId;
        public readonly IReadOnlyList<LinkmicUserInfo> LinkedUsers;
        public readonly long SourceType;
        
        private LinkerReplyContent(Models.Protobuf.Messages.LinkerReplyContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            FromRoomId = content?.FromRoomId ?? -1;
            FromUserLinkmicInfo = content?.FromUserLinkmicInfo;
            ToUserId = content?.ToUserId ?? -1;
            ToUserLinkmicInfo = content?.ToUserLinkmicInfo;
            LinkType = content?.LinkType ?? -1;
            ReplyStatus = content?.ReplyStatus ?? -1;
            LinkerSetting = content?.LinkerSetting;
            FromUser = content?.FromUser;
            ToUser = content?.ToUser;
            RtcExtInfos = content?.RtcExtInfoMap?.Count > 0 ? new ReadOnlyDictionary<long, string>(content.RtcExtInfoMap) : new ReadOnlyDictionary<long, string>(new Dictionary<long, string>(0));
            InviteeMicIdxUpdateInfo = content?.InviteeMicIdxUpdateInfo;
            ApplierMicIdxInfoMap = content?.ApplierMicIdxInfoMap?.Count > 0 ? new ReadOnlyDictionary<long, long>(content.ApplierMicIdxInfoMap) : new ReadOnlyDictionary<long, long>(new Dictionary<long, long>(0));
            HostMultiLiveEnum = content?.AnchorMultiLiveEnum ?? LinkmicMultiLiveEnum.Default;
            HostSettingInfo = content?.AnchorSettingInfo;
            ActionId = content?.ActionId ?? -1;
            LinkedUsers = content?.LinkedUsersList?.Count > 0 ? content.LinkedUsersList.Select(u => (LinkmicUserInfo)u).ToList().AsReadOnly() : new List<LinkmicUserInfo>(0).AsReadOnly();
            SourceType = content?.SourceType ?? -1;
        }

        public static implicit operator LinkerReplyContent(Models.Protobuf.Messages.LinkerReplyContent content) => new LinkerReplyContent(content);
    }
}
