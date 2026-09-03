using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class JoinDirectContent : AProtoBase
    {
        [ProtoMember(1)]
        public LinkLayerListUser Joiner { get; }

        [ProtoMember(2)]
        public AllListUser AllUsers { get; }
    }
}
