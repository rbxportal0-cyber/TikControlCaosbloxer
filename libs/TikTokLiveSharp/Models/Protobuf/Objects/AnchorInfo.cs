using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AnchorInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long Level { get; }
    }
}
