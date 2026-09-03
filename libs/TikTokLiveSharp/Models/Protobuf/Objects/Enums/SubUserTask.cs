using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubUserTask
    {
        SubUserTaskUnknown = 0,
        SubUserTaskSendEmotes = 1,
        SubUserTaskLiveAppointment = 2,
        SubUserTaskSendSubGift = 3,
        SubUserTaskInteractionComments = 4,
        SubUserTaskRenewSubscription = 5,
        SubUserTaskSubInGracePeriod = 6,
        SubUserTaskJoinDiscord = 7,
        SubUserTaskPriceChange = 8
    }
}
