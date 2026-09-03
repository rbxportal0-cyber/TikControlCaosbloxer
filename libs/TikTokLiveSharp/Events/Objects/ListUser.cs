using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ListUser
    {
        public readonly User User;
        public readonly long LinkmicId;
        public readonly string LinkmicIdString;
        public readonly LinkListStatus Status;
        public readonly LinkType LinkType;
        public readonly int UserPosition;
        public readonly LinkSilenceStatus SilenceStatus;
        public readonly long ModifyTime;
        public readonly long LinkerId;
        public readonly LinkRoleType RoleType;

        private ListUser(Models.Protobuf.Objects.ListUser user)
        {
            User = user?.User;
            LinkmicId = user?.LinkmicId ?? -1;
            LinkmicIdString = user?.LinkmicIdStr ?? string.Empty;
            Status = user?.Status ?? LinkListStatus.Status_Unknown;
            LinkType = user?.LinkType ?? LinkType.Type_Unknown;
            UserPosition = user?.UserPosition ?? -1;
            SilenceStatus = user?.SilenceStatus ?? LinkSilenceStatus.Status_Unsilence;
            ModifyTime = user?.ModifyTime ?? -1;
            LinkerId = user?.LinkerId ?? -1;
            RoleType = user?.RoleType ?? LinkRoleType.Type_Role_Type_Unknown;
        }

        public static implicit operator ListUser(Models.Protobuf.Objects.ListUser user) => new ListUser(user);
    }
}
