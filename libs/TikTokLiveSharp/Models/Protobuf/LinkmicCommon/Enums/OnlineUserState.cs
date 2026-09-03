using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum OnlineUserState
    {
        State_Undefined = 0,
        State_Normal = 1,
        State_Paused = 2
    }
}
