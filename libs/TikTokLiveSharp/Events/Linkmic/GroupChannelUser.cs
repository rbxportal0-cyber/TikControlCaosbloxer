using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class GroupChannelUser
    {
        public readonly long ChannelId;
        public readonly GroupStatus Status;
        public readonly JoinType Type;
        public readonly AllListUser AllUser;
        public readonly long JoinTime;
        public readonly long LinkedTime;
        public readonly GroupPlayer OwnerUser;

        private GroupChannelUser(Models.Protobuf.LinkmicCommon.GroupChannelUser user)
        {
            ChannelId = user?.ChannelId ?? -1;
            Status = user?.Status ?? GroupStatus.Group_Status_Unknown;
            Type = user?.Type ?? JoinType.Join_Type_Unknown;
            AllUser = user?.AllUser;
            JoinTime = user?.JoinTime ?? -1;
            LinkedTime = user?.LinkedTime ?? -1;
            OwnerUser = user?.OwnerUser;
        }

        public static implicit operator GroupChannelUser(Models.Protobuf.LinkmicCommon.GroupChannelUser user) => new GroupChannelUser(user);
    }
}
