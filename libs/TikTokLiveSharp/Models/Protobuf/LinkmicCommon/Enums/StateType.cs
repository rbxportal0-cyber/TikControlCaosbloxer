using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum StateType
    {
        State_Invalid = 0,
        State_Layout = 1,
        State_Online_User_State = 2,
        State_Audio_Mute = 3,
        State_Video_Mute = 4,
        State_RTC_Connection = 5,
        State_Network = 6,
        State_Background_Image = 7
    }
}
