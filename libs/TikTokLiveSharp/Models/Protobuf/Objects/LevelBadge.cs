using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LevelBadge : AProtoBase
    {
        [ProtoMember(1)]
        public Image OriginImg { get; }

        [ProtoMember(2)]
        public Image PreviewImg { get; }
    }
}
