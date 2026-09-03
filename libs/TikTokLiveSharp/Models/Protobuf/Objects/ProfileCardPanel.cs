using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ProfileCardPanel : AProtoBase
    {
        [ProtoMember(1)]
        public bool UseNewProfileCardStyle { get; }

        [ProtoMember(2)]
        public BadgeTextPosition BadgeTextPosition { get; }

        [ProtoMember(3)]
        public ProjectionConfig ProjectionConfig { get; }

        [ProtoMember(4)]
        public ProfileContent ProfileContent { get; }

        [ProtoMember(5)]
        public SeparatorConfig SeparatorConfig { get; }
    }
}
