using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ReplyStatus
    {
        Reply_Status_Unknown = 0,
        Reply_Status_Agree = 1,
        Reply_Status_Refuse_Personally = 2,
        Reply_Status_Refuse_Type_Not_Support = 3,
        Reply_Status_Refuse_Processing_Invitation = 4,
        Reply_Status_Refuse_By_Timeout = 5,
        Reply_Status_Refuse_Exception = 6,
        Reply_Status_Refuse_System_Not_Supported = 7,
        Reply_Status_Refuse_Subtype_Difference = 8,
        Reply_Status_Refuse_In_MicRoom = 9,
        Reply_Status_Refuse_Not_Load_Plugin = 10,
        Reply_Status_Refuse_In_Multi_Guest = 11,
        Reply_Status_Refuse_Pause_Live = 12,
        Reply_Status_Refuse_Open_Camera_Dialog_Showing = 13,
        Reply_Status_Refuse_Draw_Guessing = 14,
        Reply_Status_Refuse_Random_Matching = 15,
        Reply_Status_Refuse_In_Match_Processing = 16,
        Reply_Status_Refuse_In_MicRoom_For_Multi_Cohost = 17,
        Reply_Status_Refuse_Cohost_Finished = 18,
        Reply_Status_Refuse_Not_Connected = 19,
        Reply_Status_Refuse_Linkmic_Full = 20,
        Reply_Status_Refuse_Arc_Incompatible = 21,
        Reply_Status_Refuse_Processing_Other_Invite = 22,
        Reply_Status_Refuse_Processing_Other_Apply = 23,
        Reply_Status_Refuse_In_Anchor_Cohost = 24,
        Reply_Status_Refuse_Topic_Pairing = 25
    }
}
