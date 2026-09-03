using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicCheckPermissionScene
    {
        Unknown_Scene = 0,
        List_By_Type = 1,
        Before_Apply = 2,
        Before_Reply = 3,
        Show_Audience_Info = 4,
        Host_Live_Start = 5,
        Host_One_Click_Live_Start = 6
    }
}
