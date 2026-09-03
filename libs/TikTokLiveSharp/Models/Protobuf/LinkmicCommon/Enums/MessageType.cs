using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum MessageType
    {
        Message_Invalid = 0,
        Message_IM = 1,
        Message_RTS = 2
    }
}
