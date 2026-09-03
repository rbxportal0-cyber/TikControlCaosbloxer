using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class LinkMicMethod : AMessageData
    {
        #region InnerTypes
        public sealed class UserScores
        {
            public readonly long Score;
            public readonly long UserId;
            public readonly long WeeklyRank;

            private UserScores(Models.Protobuf.Messages.LinkMicMethod.UserScores scores)
            {
                Score = scores?.Score ?? -1;
                UserId = scores?.UserId ?? -1;
                WeeklyRank = scores?.WeeklyRank ?? -1;
            }

            public static implicit operator UserScores(Models.Protobuf.Messages.LinkMicMethod.UserScores scores) => new UserScores(scores);
        }
        
        public sealed class Contributor
        {
            public readonly long Score;
            public readonly long Rank;
            public readonly long UserId;
            public readonly User User;

            private Contributor(Models.Protobuf.Messages.LinkMicMethod.Contributor contributor)
            {
                Score = contributor?.Score ?? -1;
                Rank = contributor?.Rank ?? -1;
                UserId = contributor?.UserId ?? -1;
                User = contributor?.User;
            }

            public static implicit operator Contributor(Models.Protobuf.Messages.LinkMicMethod.Contributor contributor) => new Contributor(contributor);
        }
        
        public sealed class ContributorList
        {
            public readonly IReadOnlyList<Contributor> Contributors;

            private ContributorList(Models.Protobuf.Messages.LinkMicMethod.ContributorList list)
            {
                Contributors = list?.Contributor_List?.Count > 0 ? list.Contributor_List.Select(c => (Contributor)c).ToList().AsReadOnly() : new List<Contributor>(0).AsReadOnly();
            }

            public static implicit operator ContributorList(Models.Protobuf.Messages.LinkMicMethod.ContributorList list) => new ContributorList(list);
        }
        
        public sealed class InvitorInfo
        {
            public readonly string NickName;
            public readonly Picture Avatar;

            private InvitorInfo(Models.Protobuf.Messages.LinkMicMethod.InvitorInfo info)
            {
                NickName = info?.InvitorNickName ?? string.Empty;
                Avatar = info?.InvitorAvatar;
            }

            public static implicit operator InvitorInfo(Models.Protobuf.Messages.LinkMicMethod.InvitorInfo info) => new InvitorInfo(info);
        }
        #endregion

        public readonly long MessageType;
        public readonly string AccessKey;
        public readonly long HostLinkmicId;
        public readonly long UserId;
        public readonly long FanTicket;
        public readonly long TotalLinkmicFanTicket;
        public readonly long ChannelId;
        public readonly long Layout;
        public readonly long Vendor;
        public readonly long Dimension;
        public readonly string Theme;
        public readonly long InviteUid;
        public readonly long Answer;
        public readonly long StartTime;
        public readonly long Duration;
        public readonly IReadOnlyList<UserScores> UserScoresList;
        public readonly long MatchType;
        public readonly bool Win;
        public readonly string Prompts;
        public readonly long ToUserId;
        public readonly IReadOnlyDictionary<long, ContributorList> Contributors;
        public readonly long LinkmicLayout;
        public readonly long FromUserId;
        public readonly string Tips;
        public readonly long StartTimeMs;
        public readonly int ConfluenceType;
        public readonly long FromRoomId;
        public readonly long InviteType;
        public readonly long SubType;
        public readonly RivalExtraInfo InviterRivalExtra;
        public readonly string RtcExtInfo;
        public readonly string RtcAppId;
        public readonly string AppId;
        public readonly string AppSign;
        public readonly string RtcAppSign;
        public readonly string HostLinkmicIdString;
        public readonly long RivalHostId;
        public readonly long RivalLinkmicId;
        public readonly string RivalLinkmicIdString;
        public readonly bool ShowPopup;
        public readonly long SecInviteUid;
        public readonly long Scene;
        public readonly long SecApplyUid;
        public readonly IReadOnlyList<User> LinkedUsers;
        public readonly string SecFromUserId;
        public readonly LinkMicMethodMessageType ReplyType;
        public readonly string ReplyPrompts;
        public readonly string SecToUserId;
        public readonly InvitorInfo Invitor_Info;
        public readonly bool RtcJoinChannel;
        public readonly int FanTicketIconType;

        internal LinkMicMethod(Models.Protobuf.Messages.LinkMicMethod msg)
            : base(msg?.Header)
        {
            MessageType = msg?.MessageType ?? -1;
            AccessKey = msg?.AccessKey ?? string.Empty;
            HostLinkmicId = msg?.AnchorLinkmicId ?? -1;
            UserId = msg?.UserId ?? -1;
            FanTicket = msg?.FanTicket ?? -1;
            TotalLinkmicFanTicket = msg?.TotalLinkmicFanTicket ?? -1;
            ChannelId = msg?.ChannelId ?? -1;
            Layout = msg?.Layout ?? -1;
            Vendor = msg?.Vendor ?? -1;
            Dimension = msg?.Dimension ?? -1;
            Theme = msg?.Theme ?? string.Empty;
            InviteUid = msg?.InviteUid ?? -1;
            Answer = msg?.Answer ?? -1;
            StartTime = msg?.StartTime ?? -1;
            Duration = msg?.Duration ?? -1;
            UserScoresList = msg?.UserScoresList?.Count > 0 ? msg.UserScoresList.Select(u => (UserScores)u).ToList().AsReadOnly() : new List<UserScores>(0).AsReadOnly();
            MatchType = msg?.MatchType ?? -1;
            Win = msg?.Win ?? false;
            Prompts = msg?.Prompts ?? string.Empty;
            ToUserId = msg?.ToUserId ?? -1;
            Contributors = msg?.ContributorsMap?.Count > 0 ? new ReadOnlyDictionary<long, ContributorList>(msg.ContributorsMap.ToDictionary(k => k.Key, k => (ContributorList)k.Value)) : new ReadOnlyDictionary<long, ContributorList>(new Dictionary<long, ContributorList>(0));
            LinkmicLayout = msg?.LinkmicLayout ?? -1;
            FromUserId = msg?.FromUserId ?? -1;
            Tips = msg?.Tips ?? string.Empty;
            StartTimeMs = msg?.StartTimeMs ?? -1;
            ConfluenceType = msg?.ConfluenceType ?? -1;
            FromRoomId = msg?.FromRoomId ?? -1;
            InviteType = msg?.InviteType ?? -1;
            SubType = msg?.SubType ?? -1;
            InviterRivalExtra = msg?.InviterRivalExtra;
            RtcExtInfo = msg?.RtcExtInfo ?? string.Empty;
            RtcAppId = msg?.RtcAppId ?? string.Empty;
            AppId = msg?.AppId ?? string.Empty;
            AppSign = msg?.AppSign ?? string.Empty;
            RtcAppSign = msg?.RtcAppSign ?? string.Empty;
            HostLinkmicIdString = msg?.AnchorLinkmicIdStr ?? string.Empty;
            RivalHostId = msg?.RivalAnchorId ?? -1;
            RivalLinkmicId = msg?.RivalLinkmicId ?? -1;
            RivalLinkmicIdString = msg?.RivalLinkmicIdStr ?? string.Empty;
            ShowPopup = msg?.ShowPopup ?? false;
            SecInviteUid = msg?.SecInviteUid ?? -1;
            Scene = msg?.Scene ?? -1;
            SecApplyUid = msg?.SecApplyUid ?? -1;
            LinkedUsers = msg?.LinkedUsersList?.Count > 0 ? msg.LinkedUsersList.Select(u => (User)u).ToList().AsReadOnly() : new List<User>(0).AsReadOnly();
            SecFromUserId = msg?.SecFromUserId ?? string.Empty;
            ReplyType = msg?.ReplyType ?? LinkMicMethodMessageType.Type_None;
            ReplyPrompts = msg?.ReplyPrompts ?? string.Empty;
            SecToUserId = msg?.SecToUserId ?? string.Empty;
            Invitor_Info = msg?.Invitor_Info;
            RtcJoinChannel = msg?.RtcJoinChannel ?? false;
            FanTicketIconType = msg?.FanTicketIconType ?? -1;
        }
    }
}