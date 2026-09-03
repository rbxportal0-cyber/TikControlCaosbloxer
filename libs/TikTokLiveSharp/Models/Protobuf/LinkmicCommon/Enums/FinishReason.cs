using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum FinishReason
    {
        Finish_Reason_Unknown = 0,
        Finish_Reason_Host_Trigger = 10_001,
        Finish_Reason_M_Sequence_Permission_Finish = 10_002,
        Finish_Reason_Interrupt_By_Co_Host = 10_003,
        Finish_Reason_Illegal_Live = 10_010,
        Finish_Reason_RTC_Err = 10_011,
        Finish_Reason_Live_Stream_Err = 10_012
    }
}
