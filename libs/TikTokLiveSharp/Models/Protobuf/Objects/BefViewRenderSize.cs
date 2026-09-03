using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BefViewRenderSize : AProtoBase
    {
        [ProtoMember(1)]
        public int Width { get; }

        [ProtoMember(2)]
        public int Height { get; }
    }
}
