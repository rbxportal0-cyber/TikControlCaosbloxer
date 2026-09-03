using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class BarrageEvent
    {
        public readonly string EventName;
        public readonly IReadOnlyDictionary<string, string> ParamsMap;

        private BarrageEvent(Models.Protobuf.Messages.BarrageEvent barrageEvent)
        {
            EventName = barrageEvent?.EventName ?? string.Empty;
            ParamsMap = barrageEvent?.ParamsMap?.Count > 0 ? new ReadOnlyDictionary<string, string>(barrageEvent.ParamsMap) : new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(0));
        }

        public static implicit operator BarrageEvent(Models.Protobuf.Messages.BarrageEvent barrageEvent) => new BarrageEvent(barrageEvent);
    }
}
