using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerLinkedListChangeContent
    {
        public readonly IReadOnlyList<ListUser> LinkedUsers;

        private LinkerLinkedListChangeContent(Models.Protobuf.Messages.LinkerLinkedListChangeContent content)
        {
            LinkedUsers = content?.LinkedUsersList?.Count > 0 ? content.LinkedUsersList.Select(u => (ListUser)u).ToList().AsReadOnly() : new List<ListUser>(0).AsReadOnly();
        }

        public static implicit operator LinkerLinkedListChangeContent(Models.Protobuf.Messages.LinkerLinkedListChangeContent content) => new LinkerLinkedListChangeContent(content);
    }
}
