using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class VoteResponseData
    {
        public readonly IReadOnlyList<PollOptionInfo> Options;
        public readonly bool CommentBanned;

        private VoteResponseData(Models.Protobuf.Objects.VoteResponseData response)
        {
            Options = response?.OptionList?.Count > 0 ? response.OptionList.Select(o => (PollOptionInfo)o).ToList().AsReadOnly() : new List<PollOptionInfo>(0).AsReadOnly();
        }

        public static implicit operator VoteResponseData(Models.Protobuf.Objects.VoteResponseData response) => new VoteResponseData(response);
    }
}
