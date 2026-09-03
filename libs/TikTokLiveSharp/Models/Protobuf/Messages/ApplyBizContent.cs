using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ApplyBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; }
    }
}
