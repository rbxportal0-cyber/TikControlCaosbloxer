using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicUserStatus
    {
        UserStatus_None = 0,
        UserStatus_Linked = 1,
        UserStatus_Applying = 2,
        UserStatus_Inviting = 3
    }
}
