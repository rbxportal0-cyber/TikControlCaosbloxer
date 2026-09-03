using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class GiftDataDetailed : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; }

        [ProtoMember(2)]
        public Image Data2 { get; }

        [ProtoMember(3)]
        public uint Data3 { get; }

        [ProtoMember(4)]
        public int Data4 { get; }
    }
}
