using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class FlyingMicResources : AProtoBase
    {
        [ProtoMember(1)]
        public Image PathImage { get; }

        [ProtoMember(2)]
        public Image MicImage { get; }
    }
}
