using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PollEndContent
    {
        public readonly int EndType;
        public readonly IReadOnlyList<PollOptionInfo> Options;
        public readonly User Operator;

        private PollEndContent(Models.Protobuf.Messages.PollEndContent content)
        {
            EndType = content?.EndType ?? -1;
            Options = content?.OptionList?.Count > 0 ? content.OptionList.Select(i => (PollOptionInfo)i).ToList().AsReadOnly() : new List<PollOptionInfo>(0).AsReadOnly();
            Operator = content?.Operator;
        }

        public static implicit operator PollEndContent(Models.Protobuf.Messages.PollEndContent content) => new PollEndContent(content);
    }
}
