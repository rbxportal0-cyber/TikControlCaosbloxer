using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum RequestUserStatus
    {
        Request_UserStatus_Unknown = 0,
        Request_UserStatus_Unlinked = 1,
        Request_UserStatus_Waiting = 2,
        Request_UserStatus_Ready = 3,
        Request_UserStatus_Linked = 4
    }
}
