using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ListUser
    {
        public readonly User User;
        public readonly long ModifyTime;
        public readonly LinkType LinkType;
        public readonly LinkmicRoleType RoleType;
        public readonly string LinkmicIdString;
        public readonly long PaidMoney;
        public readonly long FanTicket;
        public readonly int FanTicketIconType;

        private ListUser(Models.Protobuf.Messages.ListUser user)
        {
            User = user?.User;
            ModifyTime = user?.ModifyTime ?? -1;
            LinkType = user?.LinkType ?? LinkType.Type_Unknown;
            RoleType = user?.RoleType ?? LinkmicRoleType.Role_Type_Unknown;
            LinkmicIdString = user?.LinkmicIdStr ?? string.Empty;
            PaidMoney = user?.PayedMoney ?? -1;
            FanTicket = user?.FanTicket ?? -1;
            FanTicketIconType = user?.FanTicketIconType ?? -1;
        }

        public static implicit operator ListUser(Models.Protobuf.Messages.ListUser user) => new ListUser(user);
    }
}
