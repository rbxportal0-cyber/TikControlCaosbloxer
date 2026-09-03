using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class DoodleTemplate : AProtoBase
    {
        [ProtoMember(1)]
        public long TemplateId { get; }

        [ProtoMember(2)]
        public Image Image { get; }
    }
}
