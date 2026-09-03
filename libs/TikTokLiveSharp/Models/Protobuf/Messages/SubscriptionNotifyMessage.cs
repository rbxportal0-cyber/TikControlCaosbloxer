using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SubscriptionNotifyMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public User User { get; }

        [ProtoMember(3)]
        public ExhibitionType ExhibitionType { get; }
    }
}
