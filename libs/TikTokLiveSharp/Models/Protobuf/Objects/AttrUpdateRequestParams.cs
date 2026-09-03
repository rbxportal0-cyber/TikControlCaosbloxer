using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AttrUpdateRequestParams : AProtoBase
    {
        [ProtoMember(1)]
        public long AttrType { get; }

        [ProtoMember(2)]
        public long Value { get; }
    }
}
