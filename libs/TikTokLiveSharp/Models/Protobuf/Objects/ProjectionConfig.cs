using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ProjectionConfig : AProtoBase
    {
        [ProtoMember(1)]
        public bool UseProjection { get; }

        [ProtoMember(2)]
        public Image Icon { get; }
    }
}
