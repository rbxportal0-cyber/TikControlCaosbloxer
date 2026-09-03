using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Beta.Data;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class LinkMicArmies : AMessageData
    {
        public readonly ulong Id;
        public readonly IReadOnlyList<LinkMicArmiesItems> Data3;
        public readonly ulong Id2;
        public readonly ulong Timestamp5;
        public readonly ulong Timestamp6;
        public readonly int BattleStatus;
        public readonly ulong Data8;
        public readonly ulong Data9;
        public readonly uint Data10;
        public readonly Picture Picture11;
        public readonly uint Data12;
        public readonly uint Data13;
        public readonly string Data17;

        internal LinkMicArmies(Models.Protobuf.UnknownObjects.LinkMicArmies msg)
            : base(msg?.Header)
        {
            Id = msg?.Id ?? 0;
            Data3 = msg?.Data3?.Count > 0 ? msg.Data3.Select(i => (LinkMicArmiesItems)i).ToList().AsReadOnly() : new List<LinkMicArmiesItems>(0).AsReadOnly();
            Id2 = msg?.Id2 ?? 0;
            Timestamp5 = msg?.Timestamp5 ?? 0;
            Timestamp6 = msg?.Timestamp6 ?? 0;
            BattleStatus = msg?.BattleStatus ?? -1;
            Data8 = msg?.Data8 ?? 0;
            Data9 = msg?.Data9 ?? 0;
            Data10 = msg?.Data10 ?? 0;
            Picture11 = msg?.Picture11;
            Data12 = msg?.Data12 ?? 0;
            Data13 = msg?.Data13 ?? 0;
            Data17 = msg?.Data17 ?? string.Empty;
        }
    }
}