using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SpotlightItem : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public Image Image { get; }

        [ProtoMember(3)]
        public SpotlightReviewStatus ReviewStatus { get; }

        [ProtoMember(4)]
        public bool IsPinned { get; }

        [ProtoMember(5)]
        public long CreateTimeSecond { get; }
    }
}
