using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GoalSchemaScene
    {
        GoalSchemaUnknown = 0,
        GoalSchemaShowEdit = 1,
        GoalSchemaShowDetail = 2,
        GoalSchemaShowManage = 3
    }
}
