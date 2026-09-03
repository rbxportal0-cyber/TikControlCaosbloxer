using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerSetting : AProtoBase
    {
        [ProtoMember(1)]
        public long MaxMemberLimit { get; }

        [ProtoMember(2)]
        public long LinkType { get; }

        [ProtoMember(3)]
        public long Scene { get; }

        [ProtoMember(4)]
        public long OwnerUserId { get; }

        [ProtoMember(5)]
        public long OwnerRoomId { get; }

        [ProtoMember(6)]
        public long Vendor { get; }
    }
}
