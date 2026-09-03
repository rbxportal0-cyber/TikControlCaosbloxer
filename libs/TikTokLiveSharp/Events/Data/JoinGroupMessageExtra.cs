using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class JoinGroupMessageExtra
    {
        public sealed class RivalExtra
        {
            public sealed class AuthenticationInfo
            {
                public readonly string CustomVerify;
                public readonly string EnterpriseVerifyReason;
                public readonly Picture AuthenticationBadge;

                private AuthenticationInfo(Models.Protobuf.Messages.JoinGroupMessageExtra.RivalExtra.AuthenticationInfo info)
                {
                    CustomVerify = info?.CustomVerify ?? string.Empty;
                    EnterpriseVerifyReason = info?.EnterpriseVerifyReason ?? string.Empty;
                    AuthenticationBadge = info?.AuthenticationBadge;
                }

                public static implicit operator AuthenticationInfo(Models.Protobuf.Messages.JoinGroupMessageExtra.RivalExtra.AuthenticationInfo info) => new AuthenticationInfo(info);
            }
            
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

            private RivalExtra(Models.Protobuf.Messages.JoinGroupMessageExtra.RivalExtra extra)
            {
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

            public static implicit operator RivalExtra(Models.Protobuf.Messages.JoinGroupMessageExtra.RivalExtra extra) => new RivalExtra(extra);
        }

        public readonly long SourceType;
        public readonly RivalExtra Extra;
        public readonly IReadOnlyList<RivalExtra> OtherUsers;

        private JoinGroupMessageExtra(Models.Protobuf.Messages.JoinGroupMessageExtra extra)
        {
            SourceType = extra?.SourceType ?? -1;
            Extra = extra?.Extra;
            OtherUsers = extra?.OtherUsersList?.Count > 0 ? extra.OtherUsersList.Select(r => (RivalExtra)r).ToList().AsReadOnly() : new List<RivalExtra>(0).AsReadOnly();
        }

        public static implicit operator JoinGroupMessageExtra(Models.Protobuf.Messages.JoinGroupMessageExtra extra) => new JoinGroupMessageExtra(extra);
    }
}
