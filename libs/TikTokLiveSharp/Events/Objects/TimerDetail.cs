using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TimerDetail
    {
        #region InnerTypes
        [System.Serializable]
        public enum AntidirtStatus
        {
            Pass = 0,
            Failed = 1
        }

        [System.Serializable]
        public enum AuditStatus
        {
            Unknown = 0,
            Pass = 1,
            Failed = 2,
            Reviewing = 3,
            Forbidden = 4
        }
        #endregion

        public readonly long TimerId;
        public readonly long HostId;
        public readonly long StartTime;
        public readonly long StartCountdownTime;
        public readonly string HostSideTitle;
        public readonly string UserSideTitle;
        public readonly long TimeIncreasePerSub;
        public readonly long TimeIncreaseCap;
        public readonly int SubCount;
        public readonly bool TimeIncreaseReachCap;
        public readonly long TotalPauseTime;
        public readonly long LastPauseTime;
        public readonly long TotalTime;
        public readonly long RemainingTime;
        public readonly long Timestamp;
        public readonly long StickerX;
        public readonly long StickerY;
        public readonly long ScreenW;
        public readonly long ScreenH;
        public readonly TimerStatus TimerStatus;
        public readonly AntidirtStatus Antidirt_Status;
        public readonly AuditStatus Audit_Status;

        private TimerDetail(Models.Protobuf.Objects.TimerDetail timerDetail)
        {
            TimerId = timerDetail?.TimerId ?? -1;
            HostId = timerDetail?.AnchorId ?? -1;
            StartTime = timerDetail?.StartTimestampS ?? -1;
            StartCountdownTime = timerDetail?.StartCountdownTimeS ?? -1;
            HostSideTitle = timerDetail?.AnchorSideTitle ?? string.Empty;
            UserSideTitle = timerDetail?.UserSideTitle ?? string.Empty;
            TimeIncreasePerSub = timerDetail?.TimeIncreasePerSubS ?? -1;
            TimeIncreaseCap = timerDetail?.TimeIncreaseCapS ?? -1;
            SubCount = timerDetail?.SubCount ?? -1;
            TimeIncreaseReachCap = timerDetail?.TimeIncreaseReachCap ?? false;
            TotalPauseTime = timerDetail?.TotalPauseTimeS ?? -1;
            LastPauseTime = timerDetail?.LastPauseTimestampS ?? -1;
            TotalTime = timerDetail?.TotalTimeS ?? -1;
            RemainingTime = timerDetail?.RemainingTimeS ?? -1;
            Timestamp = timerDetail?.TimestampS ?? -1;
            StickerX = timerDetail?.StickerX ?? -1;
            StickerY = timerDetail?.StickerY ?? -1;
            ScreenW = timerDetail?.ScreenW ?? -1;
            ScreenH = timerDetail?.ScreenH ?? -1;
            TimerStatus = timerDetail?.TimerStatus ?? TimerStatus.TimerStatusNotStarted;
            Antidirt_Status = timerDetail?.Antidirt_Status != null ? (AntidirtStatus)timerDetail.Antidirt_Status : AntidirtStatus.Pass;
            Audit_Status = timerDetail?.Audit_Status != null ? (AuditStatus)timerDetail.Audit_Status : AuditStatus.Unknown;
        }

        public static implicit operator TimerDetail(Models.Protobuf.Objects.TimerDetail timerDetail) => new TimerDetail(timerDetail);
    }
}
