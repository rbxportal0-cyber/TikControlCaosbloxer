using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class IconConfig : AProtoBase
    {
        [ProtoMember(1)]
        public Image Icon { get; }

        [ProtoMember(2)]
        public CombineBadgeBackground Background { get; }
    }
}
