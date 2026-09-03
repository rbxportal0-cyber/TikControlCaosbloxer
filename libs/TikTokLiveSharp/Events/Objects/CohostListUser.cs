using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CohostListUser
    {
        public readonly long UserId;
        public readonly string NickName;
        public readonly Picture AvatarThumb;
        public readonly long LinkedTime;
        public readonly LinkmicPlayType PlayType;
        public readonly long RoomId;
        public readonly LinkmicUserStatus LinkmicUserStatus;
        public readonly long LinkRemainingTime;
        public readonly CoHostPermissionType PermissionType;
        public readonly string DisplayId;
        public readonly long FollowStatus;
        public readonly bool IsLowVersion;
        public readonly long RivalUserId;
        public readonly long RivalRoomId;
        public readonly bool IsInitiator;
        public readonly string LinkmicId;
        public readonly long BestTeammateUid;
        public readonly bool HasTopicPerm;
        public readonly long InnerChannelId;

        private CohostListUser(Models.Protobuf.Objects.CohostListUser user)
        {
            UserId = user?.UserId ?? -1;
            NickName = user?.NickName ?? string.Empty;
            AvatarThumb = user?.AvatarThumb;
            LinkedTime = user?.LinkedTime ?? -1;
            PlayType = user?.PlayType ?? LinkmicPlayType.PlayType_Invite;
            RoomId = user?.RoomId ?? -1;
            LinkmicUserStatus = user?.LinkmicUserStatus ?? LinkmicUserStatus.UserStatus_None;
            LinkRemainingTime = user?.LinkRemainingTime ?? -1;
            PermissionType = user?.PermissionType ?? CoHostPermissionType.No_Perm;
            DisplayId = user?.DisplayId ?? string.Empty;
            FollowStatus = user?.FollowStatus ?? -1;
            IsLowVersion = user?.IsLowVersion ?? false;
            RivalUserId = user?.RivalUserId ?? -1;
            RivalRoomId = user?.RivalRoomId ?? -1;
            IsInitiator = user?.IsInitiator ?? false;
            LinkmicId = user?.LinkmicIdStr ?? string.Empty;
            BestTeammateUid = user?.BestTeammateUid ?? -1;
            HasTopicPerm = user?.HasTopicPerm ?? false;
            InnerChannelId = user?.InnerChannelId ?? -1;
        }

        public static implicit operator CohostListUser(Models.Protobuf.Objects.CohostListUser user) => new CohostListUser(user);
    }
}
