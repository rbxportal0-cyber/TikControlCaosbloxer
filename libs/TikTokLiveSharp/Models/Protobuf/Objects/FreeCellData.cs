using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class FreeCellData : AProtoBase
    {
        [ProtoMember(1)]
        public long Deprecated1 { get; }

        [ProtoMember(2)]
        public long Deprecated2 { get; }

        [ProtoMember(3)]
        public long Deprecated3 { get; }

        [ProtoMember(4)]
        public long Deprecated4 { get; }

        [ProtoMember(5)]
        public long Deprecated5 { get; }

        [ProtoMember(6)]
        public long Deprecated6 { get; }

        [ProtoMember(7)]
        public bool Deprecated7 { get; }

        [ProtoMember(8)]
        public bool Deprecated8 { get; }

        [ProtoMember(9)]
        public User Deprecated9 { get; }

        [ProtoMember(10)]
        public long Deprecated10 { get; }

        [ProtoMember(11)]
        public long Deprecated11 { get; }

        [ProtoMember(12)]
        public long Deprecated12 { get; }

        [ProtoMember(13)]
        public long Deprecated13 { get; }
    }
}
