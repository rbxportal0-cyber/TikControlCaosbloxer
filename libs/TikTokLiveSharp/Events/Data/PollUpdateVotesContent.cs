using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PollUpdateVotesContent
    {
        public readonly IReadOnlyList<PollOptionInfo> Options;

        private PollUpdateVotesContent(Models.Protobuf.Messages.PollUpdateVotesContent content)
        {
            Options = content?.OptionList?.Count > 0 ? content.OptionList.Select(i => (PollOptionInfo)i).ToList().AsReadOnly() : new List<PollOptionInfo>(0).AsReadOnly();
        }

        public static implicit operator PollUpdateVotesContent(Models.Protobuf.Messages.PollUpdateVotesContent content) => new PollUpdateVotesContent(content);
    }
}
