using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class AllListUser
    {
        public readonly IReadOnlyList<LinkLayerListUser> LinkedList;
        public readonly IReadOnlyList<LinkLayerListUser> AppliedList;
        public readonly IReadOnlyList<LinkLayerListUser> InvitedList;
        public readonly IReadOnlyList<LinkLayerListUser> ReadyList;

        private AllListUser(Models.Protobuf.LinkmicCommon.AllListUser user)
        {
            LinkedList = user?.LinkedList?.Count > 0 ? user.LinkedList.Select(u => (LinkLayerListUser)u).ToList().AsReadOnly() : new List<LinkLayerListUser>(0).AsReadOnly();
            AppliedList = user?.AppliedList?.Count > 0 ? user.AppliedList.Select(u => (LinkLayerListUser)u).ToList().AsReadOnly() : new List<LinkLayerListUser>(0).AsReadOnly();
            InvitedList = user?.InvitedList?.Count > 0 ? user.InvitedList.Select(u => (LinkLayerListUser)u).ToList().AsReadOnly() : new List<LinkLayerListUser>(0).AsReadOnly();
            ReadyList = user?.ReadyList?.Count > 0 ? user.ReadyList.Select(u => (LinkLayerListUser)u).ToList().AsReadOnly() : new List<LinkLayerListUser>(0).AsReadOnly();
        }

        public static implicit operator AllListUser(Models.Protobuf.LinkmicCommon.AllListUser user) => new AllListUser(user);
    }
}
