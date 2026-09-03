using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long MessageType { get; }

        [ProtoMember(3)]
        public long PollId { get; }

        [ProtoMember(4)]
        public PollStartContent StartContent { get; }

        [ProtoMember(5)]
        public PollEndContent EndContent { get; }

        [ProtoMember(6)]
        public PollUpdateVotesContent UpdateContent { get; }

        [ProtoMember(7)]
        public int PollKind { get; } // Possibly an Enum?
    }
}
