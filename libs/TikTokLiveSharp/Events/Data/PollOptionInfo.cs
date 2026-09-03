using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PollOptionInfo
    {
        public readonly long Votes;
        public readonly string DisplayContent;
        public readonly int OptionIdx;
        public readonly IReadOnlyList<VoteUser> VoteUsers;

        private PollOptionInfo(Models.Protobuf.Messages.PollOptionInfo info)
        {
            Votes = info?.Votes ?? -1;
            DisplayContent = info?.DisplayContent ?? string.Empty;
            OptionIdx = info?.OptionIdx ?? -1;
            VoteUsers = info?.VoteUserList?.Count > 0 ? info.VoteUserList.Select(u => (VoteUser)u).ToList().AsReadOnly() : new List<VoteUser>(0).AsReadOnly();
        }

        public static implicit operator PollOptionInfo(Models.Protobuf.Messages.PollOptionInfo info) => new PollOptionInfo(info);
    }
}
