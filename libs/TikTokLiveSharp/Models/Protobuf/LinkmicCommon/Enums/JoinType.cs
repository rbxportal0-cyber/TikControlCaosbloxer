using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum JoinType
    {
        Join_Type_Unknown = 0,
        Channel_Apply = 1,
        Channel_Invite = 2,
        Group_Apply = 100,
        Group_Apply_Follow = 101,
        Group_Invite = 102,
        Group_Invite_Follow = 103,
        Group_Owner_Join = 104
    }
}
