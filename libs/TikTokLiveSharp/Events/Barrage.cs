using TikTokLiveSharp.Events.Data;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class Barrage : AMessageData
    {
        public enum BarrageType
        {
            None = 0,
            EComOrdering = 1,
            EComBuying = 2,
            Normal = 3,
            Subscribe = 4,
            EventView = 5,
            EventRegistered = 6,
            SubscribeGift = 7,
            UserUpgrade = 8,
            GradeUserEntranceNotification = 9,
            FansLevelUpgrade = 10,
            FansLevelEntrance = 11,
            GamePartnership = 12
        }

        public readonly BarrageEvent Event;
        public readonly BarrageType MsgType;
        public readonly Picture Icon;
        public readonly Text Content;
        public readonly long Duration;
        public readonly Picture Background;
        public readonly Picture RightIcon;
        public readonly BarrageTypeUserGradeParam UserGradeParam;
        public readonly BarrageTypeFansLevelParam FansLevelParam;
        public readonly BarrageTypeSubscribeGiftParam SubscribeGiftParam;

        internal Barrage(Models.Protobuf.Messages.BarrageMessage msg)
            : base(msg?.Header)
        {
            Event = msg?.Event;
            MsgType = msg?.MsgType == null ? (BarrageType)msg.MsgType : BarrageType.None;
            Icon = msg?.Icon;
            Content = msg?.Content;
            Duration = msg?.Duration ?? -1;
            Background = msg?.Background;
            RightIcon = msg?.RightIcon;
            UserGradeParam = msg?.UserGradeParam;
            FansLevelParam = msg?.FansLevelParam;
            SubscribeGiftParam = msg?.SubscribeGiftParam;
        }
    }
}