using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EntranceGroupType
    {
        Entrance_Group_Type_Default = 0,
        Entrance_Group_Type_Gift = 1,
        Entrance_Group_Type_E_Commerce = 2,
        Entrance_Group_Type_Game = 3
    }
}
