using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ReserveReplyStatus
    {
        ReserveReplyStatusUnknown = 0,
        ReserveReplyStatusWaitForMe = 1
    }
}
