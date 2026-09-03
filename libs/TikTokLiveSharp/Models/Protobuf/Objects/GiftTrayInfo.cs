using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftTrayInfo : AProtoBase
    {
        [ProtoMember(1)]
        public Image TrayDynamicImage { get; }

        [ProtoMember(2)]
        public bool CanMirror { get; }
    }
}
