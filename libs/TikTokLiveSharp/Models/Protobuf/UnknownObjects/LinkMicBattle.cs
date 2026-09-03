using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class LinkMicBattle : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class LinkMicBattleConfig : AProtoBase
        {
            [ProtoContract]
            public partial class LinkMicBattleGift : AProtoBase
            {
                [ProtoMember(2)]
                [DefaultValue("")]
                public string Type { get; } = string.Empty;

                [ProtoMember(3)]
                public Image Picture { get; }
            }

            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(2)]
            public ulong Timestamp { get;}

            [ProtoMember(3)]
            public uint Data3 { get; }

            [ProtoMember(4)]
            public ulong Id2 { get; }

            [ProtoMember(5)]
            public uint Data5 { get; }

            [ProtoMember(6)]
            public uint Data6 { get; }

            [ProtoMember(7)]
            public LinkMicBattleGift Data7 { get; }

            [ProtoMember(8)]
            public uint Data8 { get; }
        }

        [ProtoContract]
        public partial class LinkMicBattleData : AProtoBase
        {
            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(2)]
            public uint Data2 { get; }

            [ProtoMember(3)]
            public uint Data3 { get; }

            [ProtoMember(5)]
            public uint Data5 { get; }

            [ProtoMember(6)]
            [DefaultValue("")]
            public string Url { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class LinkMicBattleDetails : AProtoBase
        {
            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(2)]
            public LinkMicBattleData Data2 { get; }
        }

        [ProtoContract]
        public partial class LinkMicBattleTeam : AProtoBase
        {
            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(2)]
            public LinkMicArmy Players { get; }
        }

        [ProtoContract]
        public partial class LinkMicBattleTeamData : AProtoBase
        {
            [ProtoMember(1)]
            public ulong TeamId { get; }

            [ProtoMember(2)]
            public LinkMicBattleData Data2 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ulong Id { get; }

        [ProtoMember(3)]
        public LinkMicBattleConfig Data3 { get; }

        [ProtoMember(4)]
        public uint Data4 { get; }

        [ProtoMember(5)]
        public List<LinkMicBattleDetails> Data5 { get; } = new List<LinkMicBattleDetails>();

        [ProtoMember(9)]
        public List<LinkMicBattleTeam> Teams1 { get; } = new List<LinkMicBattleTeam>();
        
        [ProtoMember(10)]
        public List<LinkMicBattleTeam> Teams2 { get; } = new List<LinkMicBattleTeam>();
        
        [ProtoMember(13)]
        public List<LinkMicBattleTeamData> TeamData { get; } = new List<LinkMicBattleTeamData>();

        [ProtoMember(16)]
        public ulong Id2 { get; }
    }
}
