using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ImageBadge : AProtoBase
    {
        [ProtoMember(1)]
        public BadgeDisplayType DisplayType { get; }

        [ProtoMember(2)]
        public Image Image { get; }
    }
}
