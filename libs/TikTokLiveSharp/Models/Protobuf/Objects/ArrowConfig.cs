using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ArrowConfig : AProtoBase
    {
        [ProtoMember(1)]
        public Image Icon { get; }
    }
}
