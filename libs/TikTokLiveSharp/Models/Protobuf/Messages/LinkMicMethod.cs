using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkMicMethod : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class UserScores : AProtoBase
        {
            [ProtoMember(1)]
            public long Score { get; }

            [ProtoMember(2)]
            public long UserId { get; }

            [ProtoMember(3)]
            public long WeeklyRank { get; }
        }

        [ProtoContract]
        public partial class Contributor : AProtoBase
        {
            [ProtoMember(1)]
            public long Score { get; }

            [ProtoMember(2)]
            public long Rank { get; }

            [ProtoMember(3)]
            public long UserId { get; }

            [ProtoMember(4)]
            public User User { get; }
        }

        [ProtoContract]
        public partial class ContributorList : AProtoBase
        {
            [ProtoMember(1)]
            public List<Contributor> Contributor_List { get; } = new List<Contributor>();
        }

        [ProtoContract]
        public partial class InvitorInfo : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string InvitorNickName { get; } = string.Empty;

            [ProtoMember(2)]
            public Image InvitorAvatar { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long MessageType { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string AccessKey { get; } = string.Empty;

        [ProtoMember(4)]
        public long AnchorLinkmicId { get; }

        [ProtoMember(5)]
        public long UserId { get; }

        [ProtoMember(6)]
        public long FanTicket { get; }

        [ProtoMember(7)]
        public long TotalLinkmicFanTicket { get; }

        [ProtoMember(8)]
        public long ChannelId { get; }

        [ProtoMember(9)]
        public long Layout { get; }

        [ProtoMember(10)]
        public long Vendor { get; }

        [ProtoMember(11)]
        public long Dimension { get; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string Theme { get; } = string.Empty;

        [ProtoMember(13)]
        public long InviteUid { get; }

        [ProtoMember(14)]
        public long Answer { get; }

        [ProtoMember(15)]
        public long StartTime { get; }

        [ProtoMember(16)]
        public long Duration { get; }
        
        [ProtoMember(17)]
        public List<UserScores> UserScoresList { get; } = new List<UserScores>();

        [ProtoMember(18)]
        public long MatchType { get; }

        [ProtoMember(19)]
        public bool Win { get; }

        [ProtoMember(20)]
        [DefaultValue("")]
        public string Prompts { get; } = string.Empty;

        [ProtoMember(21)]
        public long ToUserId { get; }

        [ProtoMember(22)]
        public Dictionary<long, ContributorList> ContributorsMap { get; } = new Dictionary<long, ContributorList>();

        [ProtoMember(23)]
        public long LinkmicLayout { get; }

        [ProtoMember(24)]
        public long FromUserId { get; }

        [ProtoMember(25)]
        [DefaultValue("")]
        public string Tips { get; } = string.Empty;

        [ProtoMember(26)]
        public long StartTimeMs { get; }

        [ProtoMember(27)]
        public int ConfluenceType { get; }

        [ProtoMember(28)]
        public long FromRoomId { get; }

        [ProtoMember(29)]
        public long InviteType { get; }

        [ProtoMember(30)]
        public long SubType { get; }

        [ProtoMember(31)]
        public RivalExtraInfo InviterRivalExtra { get; }

        [ProtoMember(32)]
        [DefaultValue("")]
        public string RtcExtInfo { get; } = string.Empty;

        [ProtoMember(33)]
        [DefaultValue("")]
        public string RtcAppId { get; } = string.Empty;

        [ProtoMember(34)]
        [DefaultValue("")]
        public string AppId { get; } = string.Empty;

        [ProtoMember(35)]
        [DefaultValue("")]
        public string AppSign { get; } = string.Empty;

        [ProtoMember(36)]
        [DefaultValue("")]
        public string RtcAppSign { get; } = string.Empty;

        [ProtoMember(37)]
        [DefaultValue("")]
        public string AnchorLinkmicIdStr { get; } = string.Empty;

        [ProtoMember(38)]
        public long RivalAnchorId { get; }

        [ProtoMember(39)]
        public long RivalLinkmicId { get; }
        
        [ProtoMember(40)]
        [DefaultValue("")]
        public string RivalLinkmicIdStr { get; } = string.Empty;

        [ProtoMember(41)]
        public bool ShowPopup { get; }

        [ProtoMember(42)]
        public long SecInviteUid { get; }

        [ProtoMember(43)]
        public long Scene { get; }

        [ProtoMember(44)]
        public long SecApplyUid { get; }
        
        [ProtoMember(45)]
        public List<User> LinkedUsersList { get; } = new List<User>();

        [ProtoMember(46)]
        [DefaultValue("")]
        public string SecFromUserId { get; } = string.Empty;

        [ProtoMember(47)]
        public LinkMicMethodMessageType ReplyType { get; }

        [ProtoMember(48)]
        [DefaultValue("")]
        public string ReplyPrompts { get; } = string.Empty;

        [ProtoMember(49)]
        [DefaultValue("")]
        public string SecToUserId { get; } = string.Empty;

        [ProtoMember(50)]
        public InvitorInfo Invitor_Info { get; }

        [ProtoMember(51)]
        public bool RtcJoinChannel { get; }

        [ProtoMember(52)]
        public int FanTicketIconType { get; }
    }
}
