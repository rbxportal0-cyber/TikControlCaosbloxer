using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LastLayoutSettingScene
    {
        Max_Mic_Num_Setting_Scene_Unknown = 0,
        Max_Mic_Num_Setting_Scene_Fixed_Flow_Layout = 1,
        Max_Mic_Num_Setting_Scene_Fixed_Grid_Layout = 2
    }
}
