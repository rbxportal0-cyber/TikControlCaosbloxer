using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Generic
{
    [ProtoContract]
    public partial class DataPolicyStruct : AProtoBase
    {
        [ProtoMember(1)]
        public AGType AG { get; set; }
    }
}
