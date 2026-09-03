using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum TimerOpType
    {
        TimerOpTypeStart = 0,
        TimerOpTypePause = 1,
        TimerOpTypeResume = 2,
        TimerOpTypeCancel = 3
    }
}
