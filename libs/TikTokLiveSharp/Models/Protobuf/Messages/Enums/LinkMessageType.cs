using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkMessageType
    {
        Tpye_Linker_Unknown = 0,
        Type_Linker_Create = 1,
        Type_Linker_Close = 2,
        Type_Linker_Invite = 3,
        Type_Linker_Apply = 4,
        Type_Linker_Reply = 5,
        Type_Linker_Enter = 6,
        Tpye_Linker_Leave = 7,
        Type_Linker_Permit = 8,
        Tpye_Linker_Cancel_Invite = 9,
        Type_Linker_Waiting_List_Change = 10,
        Type_Linker_Linked_List_Change = 11,
        Type_Linker_Update_User = 12,
        Tpye_Linker_Kick_Out = 13,
        Tpye_Linker_Cancel_Apply = 14,
        Type_Linker_Mute = 15,
        Type_Linker_Match = 16,
        Type_Linker_Update_User_Settings = 17,
        Type_Linker_Mic_IDX_Update = 18,
        Type_Linker_Leave_V2 = 19,
        Type_Linker_Waiting_List_Change_V2 = 20,
        Type_Linker_Linked_List_Change_V2 = 21,
        Type_Linker_CoHost_List_Change = 22,
        Type_Linker_Media_Change = 23,
        Type_Linker_Accept_Notice = 24,
        Tpye_Linker_Sys_Kick_Out = 101,
        Tpye_LinkMic_User_Toast = 102
    }
}
