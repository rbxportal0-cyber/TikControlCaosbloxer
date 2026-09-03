using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class GroupChannelUser : AProtoBase
    {
        [ProtoMember(1)]
        public long ChannelId { get; }

        [ProtoMember(2)]
        public GroupStatus Status { get; }

        [ProtoMember(3)]
        public JoinType Type { get; }

        [ProtoMember(4)]
        public AllListUser AllUser { get; }

        [ProtoMember(5)]
        public long JoinTime { get; }

        [ProtoMember(6)]
        public long LinkedTime { get; }

        [ProtoMember(7)]
        public GroupPlayer OwnerUser { get; }
    }
}
