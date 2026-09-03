using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LinkerInviteMessageExtra
    {
        #region InnerTypes
        public sealed class InviterRivalExtra
        {
            public sealed class AuthenticationInfo
            {
                public readonly string CustomVerify;
                public readonly string EnterpriseVerifyReason;
                public readonly Picture AuthenticationBadge;

                private AuthenticationInfo(Models.Protobuf.Objects.LinkerInviteMessageExtra.InviterRivalExtra.AuthenticationInfo info)
                {
                    CustomVerify = info?.CustomVerify ?? string.Empty;
                    EnterpriseVerifyReason = info?.EnterpriseVerifyReason ?? string.Empty;
                    AuthenticationBadge = info?.AuthenticationBadge;
                }

                public static implicit operator AuthenticationInfo(Models.Protobuf.Objects.LinkerInviteMessageExtra.InviterRivalExtra.AuthenticationInfo info) => new AuthenticationInfo(info);
            }

            public readonly long TextType;
            public readonly string Text;
            public readonly string Label;
            public readonly long UserCount;
            public readonly Picture AvatarThumb;
            public readonly string DisplayId;
            public readonly AuthenticationInfo Authentication_Info;
            public readonly string NickName;
            public readonly long FollowStatus;
            public readonly Hashtag Hashtag;
            public readonly TopHostInfo TopHostInfo;
            public readonly long UserId;
            public readonly bool IsBestTeammate;

            private InviterRivalExtra(Models.Protobuf.Objects.LinkerInviteMessageExtra.InviterRivalExtra extra)
            {
                TextType = extra?.TextType ?? -1;
                Text = extra?.Text ?? string.Empty;
                Label = extra?.Label ?? string.Empty;
                UserCount = extra?.UserCount ?? -1;
                AvatarThumb = extra?.AvatarThumb;
                DisplayId = extra?.DisplayId ?? string.Empty;
                Authentication_Info = extra?.Authentication_Info;
                NickName = extra?.NickName ?? string.Empty;
                FollowStatus = extra?.FollowStatus ?? -1;
                Hashtag = extra?.Hashtag;
                TopHostInfo = extra?.TopHostInfo;
                UserId = extra?.UserId ?? -1;
                IsBestTeammate = extra?.IsBestTeammate ?? false;
            }

            public static implicit operator InviterRivalExtra(Models.Protobuf.Objects.LinkerInviteMessageExtra.InviterRivalExtra extra) => new InviterRivalExtra(extra);
        }
        #endregion

        public readonly long MatchType;
        public readonly long InviteType;
        public readonly long SubType;
        public readonly string Theme;
        public readonly long Duration;
        public readonly long Layout;
        public readonly string Tips;
        public readonly InviterRivalExtra Extra;
        public readonly IReadOnlyList<InviterRivalExtra> OtherUsers;
        public readonly CohostTopic TopicInfo;

        private LinkerInviteMessageExtra(Models.Protobuf.Objects.LinkerInviteMessageExtra extra)
        {
            MatchType = extra?.MatchType ?? -1;
            InviteType = extra?.InviteType ?? -1;
            SubType = extra?.SubType ?? -1;
            Theme = extra?.Theme ?? string.Empty;
            Duration = extra?.Duration ?? -1;
            Layout = extra?.Layout ?? -1;
            Tips = extra?.Tips ?? string.Empty;
            Extra = extra?.Extra;
            OtherUsers = extra?.OtherUsersList?.Count > 0 ? extra.OtherUsersList.Select(u => (InviterRivalExtra)u).ToList().AsReadOnly() : new List<InviterRivalExtra>(0).AsReadOnly();
            TopicInfo = extra?.TopicInfo;
        }

        public static implicit operator LinkerInviteMessageExtra(Models.Protobuf.Objects.LinkerInviteMessageExtra extra) => new LinkerInviteMessageExtra(extra);
    }
}
