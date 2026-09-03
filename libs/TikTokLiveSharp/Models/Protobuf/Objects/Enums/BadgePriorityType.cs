using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BadgePriorityType
    {
        BadgePriorityType_Unknown = 0,
        BadgePriorityType_StrongRelation = 10,
        BadgePriorityType_Platform = 20,
        BadgePriorityType_Relation = 30,
        BadgePriorityType_Activity = 40,
        BadgePriorityType_RankList = 50
    }
}
