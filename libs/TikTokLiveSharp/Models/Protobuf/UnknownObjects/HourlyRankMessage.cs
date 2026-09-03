using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class HourlyRankMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class RankContainer : AProtoBase
        {
            [ProtoContract]
            public partial class RankingData : AProtoBase
            {
                [ProtoMember(1)]
                public uint Data1 { get; }

                [ProtoMember(2)]
                public Ranking Data2 { get; }

                [ProtoMember(3)]
                [DefaultValue("")]
                public string Data3 { get; } = string.Empty;
            }

            [ProtoContract]
            public partial class RankingData2 : AProtoBase
            {
                [ProtoMember(1)]
                public uint Data1 { get; }

                [ProtoMember(2)]
                public uint Data2 { get; }

                [ProtoMember(3)]
                public Ranking Data3 { get; }

                [ProtoMember(4)]
                [DefaultValue("")]
                public string Data4 { get; } = string.Empty;

                [ProtoMember(5)]
                public uint Data5 { get; }

                [ProtoMember(6)]
                public uint Data6 { get; }
            }

            [ProtoMember(1)]
            public uint Data1 { get; }

            [ProtoMember(2)]
            public RankingData Data2 { get; }

            [ProtoMember(3)]
            public uint Data3 { get; }

            [ProtoMember(4)]
            public Ranking Data4 { get; }

            [ProtoMember(5)]
            public RankingData2 Data5 { get; }

            [ProtoMember(6)]
            public uint Data6 { get; }

            [ProtoMember(7)]
            public uint Data7 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public RankContainer Data2 { get; }

        [ProtoMember(3)]
        public uint Data3 { get; }
    }
}
