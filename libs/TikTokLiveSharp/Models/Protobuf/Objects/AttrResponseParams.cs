using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AttrResponseParams : AProtoBase
    {
        [ProtoContract]
        public partial class Extra : AProtoBase
        {}

        [ProtoMember(1)]
        public UserAttrResponse Data { get; }

        [ProtoMember(2)]
        public Extra ExtraData { get; }
    }
}
