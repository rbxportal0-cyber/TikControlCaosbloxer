using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkRoleType
    {
        Type_Role_Type_Unknown = 0,
        Type_Leader = 1,
        Type_Player = 2,
        Type_Invitee = 3,
        Type_Applier = 4
    }
}
