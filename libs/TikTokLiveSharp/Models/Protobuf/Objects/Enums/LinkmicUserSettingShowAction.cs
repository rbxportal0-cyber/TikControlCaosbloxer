using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicUserSettingShowAction
    {
        Linkmic_User_Setting_Show_Action_Checked = 0,
        Linkmic_User_Setting_Show_Action_Not_Checked = 1,
        Linkmic_User_Setting_Show_Action_Hide = 2,
        Linkmic_User_Setting_Show_Action_Open = 3,
        Linkmic_User_Setting_Show_Action_Close = 4
    }
}
