using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BindingGiftMessage : AProtoBase
    {
        [ProtoMember(1)]
        public GiftMessage Message { get; }

        [ProtoMember(2)]
        public Header Header { get; }
    }
}
