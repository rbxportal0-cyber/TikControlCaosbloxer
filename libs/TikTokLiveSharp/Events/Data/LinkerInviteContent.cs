using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerInviteContent
    {
        public readonly long FromUserId;
        public readonly long FromRoomId;
        public readonly string ToRtcExtInfo;
        public readonly bool RtcJoinChannel;
        public readonly long Vendor;
        public readonly string SecFromUserId;
        public readonly string ToLinkmicIdString;
        public readonly User FromUser;
        public readonly long RequiredMicIdx;
        public readonly IReadOnlyDictionary<long, string> RtcExtInfo;
        public readonly LinkmicMultiLiveEnum HostMultiLiveEnum;
        public readonly LinkmicUserSettingInfo HostSettingInfo;
        public readonly string InviterLinkmicIdString;
        public readonly InviteTopHostInfo FromTopHostInfo;
        public readonly long ActionId;
        public readonly IReadOnlyList<LinkmicUserInfo> LinkedUsers;
        public readonly PerceptionDialogInfo Dialog;
        public readonly PunishEventInfo PunishInfo;
        public readonly int FromRoomAgeRestricted;
        public readonly Tag FromTag;
        public readonly IReadOnlyList<CohostABTestSetting> AbTestSettings;
        public readonly LinkerInviteMessageExtra LinkerInviteMsgExtra;

        private LinkerInviteContent(Models.Protobuf.Messages.LinkerInviteContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            FromRoomId = content?.FromRoomId ?? -1;
            ToRtcExtInfo = content?.ToRtcExtInfo ?? string.Empty;
            RtcJoinChannel = content?.RtcJoinChannel ?? false;
            Vendor = content?.Vendor ?? -1;
            SecFromUserId = content?.SecFromUserId ?? string.Empty;
            ToLinkmicIdString = content?.ToLinkmicIdStr ?? string.Empty;
            FromUser = content?.FromUser;
            RequiredMicIdx = content?.RequiredMicIdx ?? -1;
            RtcExtInfo = content?.RtcExtInfoMap?.Count > 0 ? new ReadOnlyDictionary<long, string>(content.RtcExtInfoMap) : new ReadOnlyDictionary<long, string>(new Dictionary<long, string>(0));
            HostMultiLiveEnum = content?.AnchorMultiLiveEnum ?? LinkmicMultiLiveEnum.Default;
            HostSettingInfo = content?.AnchorSettingInfo;
            InviterLinkmicIdString = content?.InviterLinkmicIdStr ?? string.Empty;
            FromTopHostInfo = content?.FromTopHostInfo;
            ActionId = content?.ActionId ?? -1;
            LinkedUsers = content?.LinkedUsersList?.Count > 0 ? content.LinkedUsersList.Select(u => (LinkmicUserInfo)u).ToList().AsReadOnly() : new List<LinkmicUserInfo>(0).AsReadOnly();
            Dialog = content?.Dialog;
            PunishInfo = content?.PunishInfo;
            FromRoomAgeRestricted = content?.FromRoomAgeRestricted ?? -1;
            FromTag = content?.FromTag;
            AbTestSettings = content?.AbTestSettingList?.Count > 0 ? content.AbTestSettingList.Select(s => (CohostABTestSetting)s).ToList().AsReadOnly() : new List<CohostABTestSetting>(0).AsReadOnly();
            LinkerInviteMsgExtra = content?.LinkerInviteMsgExtra;
        }

        public static implicit operator LinkerInviteContent(Models.Protobuf.Messages.LinkerInviteContent content) => new LinkerInviteContent(content);
    }
}
