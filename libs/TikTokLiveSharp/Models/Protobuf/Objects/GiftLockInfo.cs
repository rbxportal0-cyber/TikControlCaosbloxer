using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftLockInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool Lock { get; }

        [ProtoMember(2)]
        public int LockType { get; }

        [ProtoMember(3)]
        public int GiftLevel { get; }
    }
}
