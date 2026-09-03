using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GuestMicCameraChangeScene
    {
        Change_Scene_Unknown = 0,
        Live_Show_By_Anchor_Auto = 1,
        Live_Show_By_Server_Normal = 2,
        Live_Show_By_Show_End = 3
    }
}
