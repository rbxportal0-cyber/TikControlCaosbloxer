using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum UserRelationType
    {
        Relation_Unknown = 0,
        Relation_Friends = 1,
        Relation_FansClub = 2,
        Relation_Fans = 3
    }
}
