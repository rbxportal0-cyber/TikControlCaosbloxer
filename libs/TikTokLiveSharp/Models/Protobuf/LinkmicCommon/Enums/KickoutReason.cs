using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum KickoutReason
    {
        Kickout_Reason_Unknown = 0,
        Kickout_Reason_First_Frame_Timeout = 1,
        Kickout_Reason_By_Host = 2,
        Kickout_Reason_RTC_Lost_Connection = 3,
        Kickout_Reason_By_Punish = 4,
        Kickout_Reason_By_Admin = 5,
        Kickout_Reason_Host_Remove_All_Guests = 6
    }
}
