using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class FinishChannelContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Owner { get; }

        [ProtoMember(2)]
        public long FinishReason { get; }
    }
}
