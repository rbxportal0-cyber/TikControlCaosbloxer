using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LeaveReason
    {
        Leave_Reason_Unknown = 0,
        Leave_Reason_By_Client = 10_000,
        Leave_Reason_Click_Window = 10_001,
        Leave_Reason_Click_Panel = 10_002,
        Leave_Reason_Exit_Live_Room = 10_003,
        Leave_Reason_Feedback = 10_004,
        Leave_Reason_OneClick_Go_Live = 10_005,
        Leave_Reason_ReEnter_Room = 10_011,
        Leave_Reason_Linkmic_Slot_Full = 10_012,
        Leave_Reason_Kill_Background_Three_Mins = 10_013,
        Leave_Reason_Kill_Process = 10_014,
        Leave_Reason_Pip = 10_015,
        Leave_Reason_Copyright_Warning = 10_016,
        Leave_Reason_Only_Me = 10_017,
        Leave_Reason_Reset_Ready_Or_Waiting = 10_018,
        Leave_Reason_Reply_Failure = 10_021,
        Leave_Reason_JoinChannel_Failure = 10_022,
        Leave_Reason_Permit_Timeout = 10_023,
        Leave_Reason_RTC_Unrecoverable_Error = 10_031,
        Leave_Reason_RTC_Start_Failure = 10_032,
        Leave_Reason_Local_Stream_Timeout = 10_033,
        Leave_Reason_Anchor_Offline = 10_034,
        Leave_Reason_Close_Apply_Voice_Mic_Panel = 10_041,
        Leave_Reason_Close_Invited_Voice_Mic_Panel = 10_042,
        Leave_Reason_Close_Apply_Preview_Panel = 10_043,
        Leave_Reason_Close_Invited_Preview_Panel = 10_044,
        Leave_Reason_Apply_Voice_Mic_Panel_Timeout = 10_045,
        Leave_Reason_Invited_Voice_Mic_Panel_Timeout = 10_046,
        Leave_Reason_Apply_Preview_Panel_Timeout = 10_047,
        Leave_Reason_Invited_Preview_Panel_Timeout = 10_048,
        Leave_Reason_By_Server = 20_000
    }
}
