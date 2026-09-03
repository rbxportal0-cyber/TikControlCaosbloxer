using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubscriptionInfo : AProtoBase
    {
        [ProtoMember(1)]
        public SubscribingStatus CurrentStatus { get; }
    }
}
