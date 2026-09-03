using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubTimerSticker
    {
        public readonly SubTimerStickerChangeType Type;
        public readonly long TimerId;
        public readonly TimerOpType OpType;
        public readonly TimerStatus TimerStatus;
        public readonly string HostSideTitle;
        public readonly string UserSideTitle;
        public readonly int SubIncreaseCount;
        public readonly long TimeIncreasePerSub;
        public readonly long TimeIncrease;
        public readonly long TotalTime;
        public readonly long RemainingTime;
        public readonly long Timestamp;
        public readonly long StickerX;
        public readonly long StickerY;
        public readonly long ScreenW;
        public readonly long ScreenH;

        private SubTimerSticker(Models.Protobuf.Objects.SubTimerSticker sticker)
        {
            Type = sticker?.Type ?? SubTimerStickerChangeType.TitleChange;
            TimerId = sticker?.TimerId ?? -1;
            OpType = sticker?.OpType ?? TimerOpType.TimerOpTypeStart;
            TimerStatus = sticker?.TimerStatus ?? TimerStatus.TimerStatusNotStarted;
            HostSideTitle = sticker?.AnchorSideTitle ?? string.Empty;
            UserSideTitle = sticker?.UserSideTitle ?? string.Empty;
            SubIncreaseCount = sticker?.SubIncreaseCount ?? -1;
            TimeIncreasePerSub = sticker?.TimeIncreasePerSub ?? -1;
            TimeIncrease = sticker?.TimeIncrease ?? -1;
            TotalTime = sticker?.TotalTime ?? -1;
            RemainingTime = sticker?.RemainingTime ?? -1;
            Timestamp = sticker?.Timestamp ?? -1;
            StickerX = sticker?.StickerX ?? -1;
            StickerY = sticker?.StickerY ?? -1;
            ScreenW = sticker?.ScreenW ?? -1;
            ScreenH = sticker?.ScreenH ?? -1;
        }

        public static implicit operator SubTimerSticker(Models.Protobuf.Objects.SubTimerSticker sticker) => new SubTimerSticker(sticker);
    }
}
