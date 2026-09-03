using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum UserOnlineStatus
    {
        User_Online_Status_Unknown = 0,
        User_Online_Status_Online = 1,
        User_Online_Status_Offline = 2
    }
}
