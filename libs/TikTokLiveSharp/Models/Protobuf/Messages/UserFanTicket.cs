using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class UserFanTicket : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        public long FanTicket { get; }

        [ProtoMember(3)]
        public long MatchTotalScore { get; }

        [ProtoMember(4)]
        public int MatchRank { get; }
    }
}
