using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class UserVoteInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool HasVoted { get; }

        [ProtoMember(2)]
        public int VoteOptionIndex { get; }
    }
}
