using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicReplyType
    {
        RT_Unknown = 0,
        RT_Agree = 1,
        RT_Reject = 2
    }
}
