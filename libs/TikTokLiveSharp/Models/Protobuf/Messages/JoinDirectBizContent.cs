using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class JoinDirectBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public long ReplyImMsgId { get; }
    }
}
