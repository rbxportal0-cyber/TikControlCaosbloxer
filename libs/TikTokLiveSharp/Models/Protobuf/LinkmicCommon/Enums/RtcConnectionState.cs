using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum RtcConnectionState
    {
        State_RTC_Undefined = 0,
        State_RTC_Normal = 1,
        State_RTC_Diconnect = 2
    }
}
