using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LiveEventInfo : AProtoBase
    {
        [ProtoContract]
        [System.Serializable]
        public enum EventPayMethod
        {
            EventPayMethodInvalid = 0,
            EventPayMethodCoins = 1,
            EventPayMethodCash = 2
        }

        [ProtoMember(1)]
        public long EventId { get; }

        [ProtoMember(2)]
        public long StartTime { get; }

        [ProtoMember(3)]
        public long Duration { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Description { get; } = string.Empty;

        [ProtoMember(6)]
        public bool HasSubscribed { get; }

        [ProtoMember(7)]
        public bool IsPaidEvent { get; }

        [ProtoMember(8)]
        public long TicketAmount { get; }

        [ProtoMember(9)]
        public EventPayMethod PayMethod { get; }

        [ProtoMember(10)]
        public Dictionary<string, WalletPackage> WalletPkgDictMap { get; } = new Dictionary<string, WalletPackage>();
    }
}
