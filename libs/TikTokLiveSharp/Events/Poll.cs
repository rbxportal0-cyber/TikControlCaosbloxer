using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events
{
    public sealed class Poll : AMessageData
    {
        public readonly long MessageType;
        public readonly long PollId;
        public readonly PollStartContent StartContent;
        public readonly PollEndContent EndContent;
        public readonly PollUpdateVotesContent UpdateContent;
        public readonly int PollKind;

        internal Poll(Models.Protobuf.Messages.PollMessage msg)
            : base(msg?.Header)
        {
            MessageType = msg?.MessageType ?? -1;
            PollId = msg?.PollId ?? -1;
            StartContent = msg?.StartContent;
            EndContent = msg?.EndContent;
            UpdateContent = msg?.UpdateContent;
            PollKind = msg?.PollKind ?? -1;
        }
    }
}