using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class MonkeyGiftRankData : AProtoBase
    {
        [ProtoContract]
        public partial class Rank : AProtoBase
        {
            [ProtoMember(1)]
            public User Deprecated1 { get; }

            [ProtoMember(2)]
            public bool Deprecated2 { get; }

            [ProtoMember(3)]
            public long Deprecated3 { get; }

            [ProtoMember(4)]
            public int Deprecated4 { get; }

            [ProtoMember(5)]
            public int Deprecated5 { get; }

            [ProtoMember(6)]
            public int Deprecated6 { get; }

            [ProtoMember(7)]
            [DefaultValue("")]
            public string Deprecated7 { get; } = string.Empty;

            [ProtoMember(8)]
            [DefaultValue("")]
            public string Deprecated8 { get; } = string.Empty;

            [ProtoMember(9)]
            [DefaultValue("")]
            public string Deprecated9 { get; } = string.Empty;

            [ProtoMember(10)]
            [DefaultValue("")]
            public string SecAnchorId { get; } = string.Empty;
        }

        [ProtoMember(1)]
        public long Deprecated1 { get; }

        [ProtoMember(2)]
        public Rank Deprecated2 { get; }

        [ProtoMember(3)]
        public int Deprecated3 { get; }

        [ProtoMember(4)]
        public List<Rank> Deprecated4List { get; } = new List<Rank>();

        [ProtoMember(5)]
        public Rank Deprecated5 { get; }

        [ProtoMember(6)]
        public bool Deprecated6 { get; }
    }
}
