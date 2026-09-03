using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class NumberConfig : AProtoBase
    {
        [ProtoMember(1)]
        public long Number { get; }

        [ProtoMember(2)]
        public FontStyle FontStyle { get; }

        [ProtoMember(3)]
        public CombineBadgeBackground Background { get; }
    }
}
