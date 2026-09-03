using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class RankTextMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }
        
        [ProtoMember(2)]
        public int Scene { get; }

        [ProtoMember(3)]
        public long OwnerIdxBeforeUpdate { get; }

        [ProtoMember(4)]
        public long OwnerIdxAfterUpdate { get; }

        [ProtoMember(5)]
        public Text SelfGetBadgeMsg { get; }

        [ProtoMember(6)]
        public Text OtherGetBadgeMsg { get; }

        [ProtoMember(7)]
        public long CurUserId { get; }
    }
}
