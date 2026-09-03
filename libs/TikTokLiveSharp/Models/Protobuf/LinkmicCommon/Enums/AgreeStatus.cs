using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum AgreeStatus
    {
        Agree_Unknown = 0,
        Agree = 1,
        Reject = 2
    }
}
