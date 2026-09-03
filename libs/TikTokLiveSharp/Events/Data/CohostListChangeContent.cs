using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class CohostListChangeContent
    {
        public readonly IReadOnlyList<CohostListUser> Users;

        private CohostListChangeContent(Models.Protobuf.Messages.CohostListChangeContent content)
        {
            Users = content?.UsersList?.Count > 0 ? content.UsersList.Select(u => (CohostListUser)u).ToList().AsReadOnly() : new List<CohostListUser>(0).AsReadOnly();
        }

        public static implicit operator CohostListChangeContent(Models.Protobuf.Messages.CohostListChangeContent content) => new CohostListChangeContent(content);
    }
}
