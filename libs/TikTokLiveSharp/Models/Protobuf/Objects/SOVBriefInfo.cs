using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SOVBriefInfo : AProtoBase
    {
        [ProtoMember(1)]
        public Image Cover { get; }

        [ProtoMember(2)]
        public SOVMaskInfo MaskInfo { get; }
    }
}
