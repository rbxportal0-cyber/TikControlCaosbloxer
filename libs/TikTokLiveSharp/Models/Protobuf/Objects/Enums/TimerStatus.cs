using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum TimerStatus
    {
        TimerStatusNotStarted = 0,
        TimerStatusRunning = 1,
        TimerStatusPaused = 2,
        TimerStatusCancelled = 3,
        TimerStatusFinished = 4
    }
}
