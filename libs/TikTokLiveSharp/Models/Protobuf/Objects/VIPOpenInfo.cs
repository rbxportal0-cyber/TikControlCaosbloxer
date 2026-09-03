using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class VIPOpenInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long OpenPrice { get; }

        [ProtoMember(2)]
        public long RenewPrice { get; }
    }
}
