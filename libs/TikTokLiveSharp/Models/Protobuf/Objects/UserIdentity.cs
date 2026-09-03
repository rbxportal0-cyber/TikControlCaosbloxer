using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class UserIdentity : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsGiftGiverOfAnchor { get; }

        [ProtoMember(2)]
        public bool IsSubscriberOfAnchor { get; }

        [ProtoMember(3)]
        public bool IsMutualFollowingWithAnchor { get; }

        [ProtoMember(4)]
        public bool IsFollowerOfAnchor { get; }

        [ProtoMember(5)]
        public bool IsModeratorOfAnchor { get; }

        [ProtoMember(6)]
        public bool IsAnchor { get; }
    }
}
