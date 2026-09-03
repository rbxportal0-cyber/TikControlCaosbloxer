using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgePreview : AProtoBase
    {
        [ProtoMember(1)]
        public int SubLevel { get; }

        [ProtoMember(2)]
        public Image MixedImage { get; }

        [ProtoMember(3)]
        public BadgeStruct BadgeStruct { get; }
    }
}
