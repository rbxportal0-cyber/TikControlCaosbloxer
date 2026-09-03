using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Beta.Data;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class LinkMicBattle : AMessageData
    {
        #region InnerTypes
        public sealed class LinkMicBattleConfig
        {
            public sealed class LinkMicBattleGift
            {
                public readonly string Type;
                public readonly Picture Picture;

                private LinkMicBattleGift(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleConfig.LinkMicBattleGift gift)
                {
                    Type = gift?.Type ?? string.Empty;
                    Picture = gift?.Picture;
                }

                public static implicit operator LinkMicBattleGift(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleConfig.LinkMicBattleGift gift) => new LinkMicBattleGift(gift);
            }
            
            public readonly ulong Id;
            public readonly ulong Timestamp;
            public readonly uint Data3;
            public readonly ulong Id2;
            public readonly uint Data5;
            public readonly uint Data6;
            public readonly LinkMicBattleGift Data7;
            public readonly uint Data8;

            private LinkMicBattleConfig(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleConfig config)
            {
                Id = config?.Id ?? 0;
                Timestamp = config?.Timestamp ?? 0;
                Data3 = config?.Data3 ?? 0;
                Id2 = config?.Id2 ?? 0;
                Data5 = config?.Data5 ?? 0;
                Data6 = config?.Data6 ?? 0;
                Data7 = config?.Data7;
                Data8 = config?.Data8 ?? 0;
            }

            public static implicit operator LinkMicBattleConfig(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleConfig config) => new LinkMicBattleConfig(config);
        }
        
        public sealed class LinkMicBattleData
        {
            public readonly ulong Id;
            public readonly uint Data2;
            public readonly uint Data3;
            public readonly uint Data5;
            public readonly string Url;

            private LinkMicBattleData(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleData data)
            {
                Id = data?.Id ?? 0;
                Data2 = data?.Data2 ?? 0;
                Data3 = data?.Data3 ?? 0;
                Data5 = data?.Data5 ?? 0;
                Url = data?.Url ?? string.Empty;
            }

            public static implicit operator LinkMicBattleData(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleData data) => new LinkMicBattleData(data);
        }
        
        public sealed class LinkMicBattleDetails
        {
            public readonly ulong Id;
            public readonly LinkMicBattleData Data2;

            private LinkMicBattleDetails(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleDetails details)
            {
                Id = details?.Id ?? 0;
                Data2 = details?.Data2;
            }

            public static implicit operator LinkMicBattleDetails(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleDetails details) => new LinkMicBattleDetails(details);
        }
        
        public sealed class LinkMicBattleTeam
        {
            public readonly ulong Id;
            public readonly LinkMicArmy Players;

            private LinkMicBattleTeam(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleTeam team)
            {
                Id = team?.Id ?? 0;
                Players = team?.Players;
            }

            public static implicit operator LinkMicBattleTeam(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleTeam team) => new LinkMicBattleTeam(team);
        }
        
        public sealed class LinkMicBattleTeamData
        {
            public readonly ulong TeamId;
            public readonly LinkMicBattleData Data2;

            private LinkMicBattleTeamData(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleTeamData data)
            {
                TeamId = data?.TeamId ?? 0;
                Data2 = data?.Data2;
            }

            public static implicit operator LinkMicBattleTeamData(Models.Protobuf.UnknownObjects.LinkMicBattle.LinkMicBattleTeamData data) => new LinkMicBattleTeamData(data);
        }
        #endregion

        public readonly ulong Id;
        public readonly LinkMicBattleConfig Data3;
        public readonly uint Data4;
        public readonly IReadOnlyList<LinkMicBattleDetails> Data5;
        public readonly IReadOnlyList<LinkMicBattleTeam> Teams1;
        public readonly IReadOnlyList<LinkMicBattleTeam> Teams2;
        public readonly IReadOnlyList<LinkMicBattleTeamData> TeamData;
        public readonly ulong Id2;

        internal LinkMicBattle(Models.Protobuf.UnknownObjects.LinkMicBattle msg)
            : base(msg?.Header)
        {
            Id = msg?.Id ?? 0;
            Data3 = msg?.Data3;
            Data4 = msg?.Data4 ?? 0;
            Data5 = msg?.Data5?.Count > 0 ? msg.Data5.Select(d => (LinkMicBattleDetails)d).ToList().AsReadOnly() : new List<LinkMicBattleDetails>(0).AsReadOnly();
            Teams1 = msg?.Teams1?.Count > 0 ? msg.Teams1.Select(d => (LinkMicBattleTeam)d).ToList().AsReadOnly() : new List<LinkMicBattleTeam>(0).AsReadOnly();
            Teams2 = msg?.Teams2?.Count > 0 ? msg.Teams2.Select(d => (LinkMicBattleTeam)d).ToList().AsReadOnly() : new List<LinkMicBattleTeam>(0).AsReadOnly();
            TeamData = msg?.TeamData?.Count > 0 ? msg.TeamData.Select(d => (LinkMicBattleTeamData)d).ToList().AsReadOnly() : new List<LinkMicBattleTeamData>(0).AsReadOnly();
            Id2 = msg?.Id2 ?? 0;
        }
    }
}