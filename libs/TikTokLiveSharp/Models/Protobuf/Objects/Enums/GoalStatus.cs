using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GoalStatus
    {
        GoalStatusUnknown = 0,
        GoalStatusNotStart = 1,
        GoalStatusOngoing = 2,
        GoalStatusFinished = 3,
        GoalStatusDeleted = 4
    }
}
