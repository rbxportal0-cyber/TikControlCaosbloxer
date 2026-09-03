using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LiveEventInfo
    {
        [System.Serializable]
        public enum EventPayMethod
        {
            Invalid = 0,
            Coins = 1,
            Cash = 2
        }

        public readonly long EventId;
        public readonly long StartTime;
        public readonly long Duration;
        public readonly string Title;
        public readonly string Description;
        public readonly bool HasSubscribed;
        public readonly bool IsPaidEvent;
        public readonly long TicketAmount;
        public readonly EventPayMethod PayMethod;
        public readonly IReadOnlyDictionary<string, WalletPackage> WalletPkgMap;

        private LiveEventInfo(Models.Protobuf.Objects.LiveEventInfo evtInfo)
        {
            EventId = evtInfo?.EventId ?? -1;
            StartTime = evtInfo?.StartTime ?? -1;
            Duration = evtInfo?.Duration ?? -1;
            Title = evtInfo?.Title ?? string.Empty;
            Description = evtInfo?.Description ?? string.Empty;
            HasSubscribed = evtInfo?.HasSubscribed ?? false;
            IsPaidEvent = evtInfo?.IsPaidEvent ?? false;
            TicketAmount = evtInfo?.TicketAmount ?? -1;
            PayMethod = evtInfo?.PayMethod != null ? (EventPayMethod)evtInfo.PayMethod : EventPayMethod.Invalid;
            WalletPkgMap = evtInfo?.WalletPkgDictMap?.Count > 0 ? new ReadOnlyDictionary<string, WalletPackage>(evtInfo.WalletPkgDictMap.ToDictionary(s => s.Key, p => (WalletPackage)p.Value)) : new ReadOnlyDictionary<string, WalletPackage>(new Dictionary<string, WalletPackage>(0));
        }

        public static implicit operator LiveEventInfo(Models.Protobuf.Objects.LiveEventInfo evtInfo) => new LiveEventInfo(evtInfo);
    }
}
