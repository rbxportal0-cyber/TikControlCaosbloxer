using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GoalType
    {
        GoalTypeUnknown = 0,
        GoalTypeStream = 1,
        GoalTypeSubscription = 2
    }
}
