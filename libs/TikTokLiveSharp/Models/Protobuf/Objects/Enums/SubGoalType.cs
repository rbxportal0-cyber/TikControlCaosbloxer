using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubGoalType
    {
        SubGoalTypeUnknown = 0,
        SubGoalTypeGift = 1,
        SubGoalTypeSubscription = 2
    }
}
