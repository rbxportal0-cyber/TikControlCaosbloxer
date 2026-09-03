using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class GroupPlayer : AProtoBase
    {
        [ProtoMember(1)]
        public long ChannelId { get; }

        [ProtoMember(2)]
        public Player User { get; }
    }
}
