using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubscribingStatus
    {
        SubscribingStatus_Unknown = 0,
        SubscribingStatus_Once = 1,
        SubscribingStatus_Circle = 2,
        SubscribingStatus_CircleCancel = 3,
        SubscribingStatus_Refund = 4,
        SubscribingStatus_InGracePeriod = 5,
        SubscribingStatus_NotInGracePeriod = 6
    }
}
