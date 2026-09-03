using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class GroupChannelAllUser
    {
        public readonly long GroupChannelId;
        public readonly IReadOnlyList<GroupChannelUser> Users;

        private GroupChannelAllUser(Models.Protobuf.LinkmicCommon.GroupChannelAllUser user)
        {
            GroupChannelId = user?.GroupChannelId ?? -1;
            Users = user?.UserList?.Count > 0 ? user.UserList.Select(u => (GroupChannelUser)u).ToList().AsReadOnly() : new List<GroupChannelUser>(0).AsReadOnly();
        }

        public static implicit operator GroupChannelAllUser(Models.Protobuf.LinkmicCommon.GroupChannelAllUser user) => new GroupChannelAllUser(user);
    }
}
