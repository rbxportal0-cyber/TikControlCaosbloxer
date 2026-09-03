using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class GroupChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public GroupChannelAllUser GroupUser { get; }
    }
}
