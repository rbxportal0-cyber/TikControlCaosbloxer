using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PollStartContent
    {
        public readonly long StartTime;
        public readonly long EndTime;
        public readonly IReadOnlyList<PollOptionInfo> Options;
        public readonly string Title;
        public readonly User Operator;

        private PollStartContent(Models.Protobuf.Messages.PollStartContent content)
        {
            StartTime = content?.StartTime ?? -1;
            EndTime = content?.EndTime ?? -1;
            Options = content?.OptionList?.Count > 0 ? content.OptionList.Select(i => (PollOptionInfo)i).ToList().AsReadOnly() : new List<PollOptionInfo>(0).AsReadOnly();
            Title = content?.Title ?? string.Empty;
            Operator = content?.Operator;
        }

        public static implicit operator PollStartContent(Models.Protobuf.Messages.PollStartContent content) => new PollStartContent(content);
    }
}
