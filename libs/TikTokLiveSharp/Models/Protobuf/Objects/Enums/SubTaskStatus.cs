using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubTaskStatus
    {
        SubTaskStatusUnknown = 0,
        SubTaskStatusNormal = 1,
        SubTaskStatusFirstOnboarding = 2,
        SubTaskStatusFinishedOnboarding = 3
    }
}
