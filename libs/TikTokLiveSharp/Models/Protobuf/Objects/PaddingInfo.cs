using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PaddingInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool UseSpecific { get; }

        [ProtoMember(2)]
        public int MiddlePadding { get; }

        [ProtoMember(3)]
        public int BadgeWidth { get; }

        [ProtoMember(4)]
        public int LeftPadding { get; }

        [ProtoMember(5)]
        public int RightPadding { get; }

        [ProtoMember(6)]
        public int IconTopPadding { get; }

        [ProtoMember(7)]
        public int IconBottomPadding { get; }

        [ProtoMember(8)]
        public HorizontalPaddingRule HorizontalPaddingRule { get; }

        [ProtoMember(9)]
        public VerticalPaddingRule VerticalPaddingRule { get; }
    }
}
