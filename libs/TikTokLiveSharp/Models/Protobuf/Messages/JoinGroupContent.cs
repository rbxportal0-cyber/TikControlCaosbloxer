using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class JoinGroupContent : AProtoBase
    {
        [ProtoMember(1)]
        public GroupChannelAllUser GroupUser { get; }

        [ProtoMember(2)]
        public GroupPlayer JoinUser { get; }

        [ProtoMember(3)]
        public JoinType Type { get; }
    }
}
