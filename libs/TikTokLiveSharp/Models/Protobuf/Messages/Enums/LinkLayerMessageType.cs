using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkLayerMessageType
    {
        Linker_Unknown = 0,
        Linker_Create = 1,
        Linker_Invite = 2,
        Linker_Apply = 3,
        Linker_Permit = 4,
        Linker_Reply = 5,
        Linker_Kick_Out = 6,
        Linker_Cancel_Apply = 7,
        Linker_Cancel_Invite = 8,
        Linker_Leave = 9,
        Linker_Finish = 10,
        Linker_List_Change = 11,
        Linker_Join_Direct = 12,
        Linker_Join_Group = 13,
        Linker_Permit_Group = 14,
        Linker_Cancel_Group = 15,
        Linker_Leave_Group = 16,
        Linker_P2P_Group_Change = 17,
        Linker_Group_Change = 18
    }
}
