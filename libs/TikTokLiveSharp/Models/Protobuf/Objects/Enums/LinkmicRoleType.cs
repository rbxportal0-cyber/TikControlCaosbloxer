using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicRoleType
    {
        Role_Type_Unknown = 0,
        Leader = 1,
        Player = 2,
        Invitee = 3
    }
}
