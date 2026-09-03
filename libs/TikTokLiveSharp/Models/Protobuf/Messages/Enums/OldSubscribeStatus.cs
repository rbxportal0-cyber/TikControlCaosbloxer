using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum OldSubscribeStatus
    {
        OldSubscribeStatus_First = 0,
        OldSubscribeStatus_Resub = 1,
        OldSubscribeStatus_SubInGracePeriod = 2,
        OldSubscribeStatus_SubNotInGracePeriod = 3,
        OldSubscribeStatus_Default = 100
    }
}
