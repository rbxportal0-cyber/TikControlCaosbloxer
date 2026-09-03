using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GameGiftData : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class MonkeyData : AProtoBase
        {
            [ProtoContract]
            public partial class Range : AProtoBase
            {
                [ProtoMember(1)]
                public int Deprecated1 { get; }

                [ProtoMember(2)]
                public int Deprecated2 { get; }

                [ProtoMember(3)]
                public int Deprecated3 { get; }
            }

            [ProtoMember(1)]
            public uint Deprecated1 { get; }

            [ProtoMember(2)]
            public uint Deprecated2 { get; }

            [ProtoMember(3)]
            public uint Deprecated3 { get; }

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated4 { get; } = string.Empty;

            [ProtoMember(5)]
            public List<Range> Deprecated5List { get; } = new List<Range>();

            [ProtoMember(6)]
            [DefaultValue("")]
            public string Deprecated6 { get; } = string.Empty;

            [ProtoMember(7)]
            public int Deprecated7 { get; }

            [ProtoMember(8)]
            public int Deprecated8 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public MonkeyData Deprecated1 { get; }
    }
}
