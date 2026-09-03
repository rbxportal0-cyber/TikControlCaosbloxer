using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerInviteContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public long FromRoomId { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string ToRtcExtInfo { get; } = string.Empty;

        [ProtoMember(4)]
        public bool RtcJoinChannel { get; }

        [ProtoMember(5)]
        public long Vendor { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string SecFromUserId { get; } = string.Empty;

        [ProtoMember(7)]
        [DefaultValue("")]
        public string ToLinkmicIdStr { get; } = string.Empty;

        [ProtoMember(8)]
        public User FromUser { get; }

        [ProtoMember(9)]
        public long RequiredMicIdx { get; }

        [ProtoMember(10)]
        public Dictionary<long, string> RtcExtInfoMap { get; } = new Dictionary<long, string>();

        [ProtoMember(11)]
        public LinkmicMultiLiveEnum AnchorMultiLiveEnum { get; }

        [ProtoMember(12)]
        public LinkmicUserSettingInfo AnchorSettingInfo { get; }

        [ProtoMember(13)]
        [DefaultValue("")]
        public string InviterLinkmicIdStr { get; } = string.Empty;

        [ProtoMember(16)]
        public InviteTopHostInfo FromTopHostInfo { get; }

        [ProtoMember(17)]
        public long ActionId { get; }

        [ProtoMember(18)]
        public List<LinkmicUserInfo> LinkedUsersList { get; } = new List<LinkmicUserInfo>();

        [ProtoMember(19)]
        public PerceptionDialogInfo Dialog { get; }

        [ProtoMember(20)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(21)]
        public int FromRoomAgeRestricted { get; }

        [ProtoMember(22)]
        public Tag FromTag { get; }

        [ProtoMember(23)]
        public List<CohostABTestSetting> AbTestSettingList { get; } = new List<CohostABTestSetting>();

        [ProtoMember(101)]
        public LinkerInviteMessageExtra LinkerInviteMsgExtra { get; }
    }
}
