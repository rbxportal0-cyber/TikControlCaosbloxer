using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class MsgFilter : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsGifter { get; }

        [ProtoMember(2)]
        public bool IsSubscribedToAnchor { get; }
    }
}
