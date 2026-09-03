using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ListChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public ListChangeType Type { get; }

        [ProtoMember(2)]
        public AllListUser List { get; }
    }
}
