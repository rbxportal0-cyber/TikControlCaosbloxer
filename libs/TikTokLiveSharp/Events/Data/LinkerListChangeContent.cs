using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerListChangeContent
    {
        public readonly IReadOnlyList<ListUser> LinkedUsers;
        public readonly IReadOnlyList<ListUser> AppliedUsers;
        public readonly IReadOnlyList<ListUser> ConnectingUsers;

        private LinkerListChangeContent(Models.Protobuf.Messages.LinkerListChangeContent content)
        {
            LinkedUsers = content?.LinkedUsersList?.Count > 0 ? content.LinkedUsersList.Select(u => (ListUser)u).ToList().AsReadOnly() : new List<ListUser>(0).AsReadOnly();
            AppliedUsers = content?.AppliedUsersList?.Count > 0 ? content.AppliedUsersList.Select(u => (ListUser)u).ToList().AsReadOnly() : new List<ListUser>(0).AsReadOnly();
            ConnectingUsers = content?.ConnectingUsersList?.Count > 0 ? content.ConnectingUsersList.Select(u => (ListUser)u).ToList().AsReadOnly() : new List<ListUser>(0).AsReadOnly();
        }

        public static implicit operator LinkerListChangeContent(Models.Protobuf.Messages.LinkerListChangeContent content) => new LinkerListChangeContent(content);
    }
}
