using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ListChangeType
    {
        List_Leave = 0,
        List_Join_Channel = 1,
        List_Apply = 2,
        List_Invite = 3,
        List_Kick_Out = 4,
        List_Cancel_Invite = 5,
        List_Cancel_Apply = 6,
        List_Join_Direct = 7,
        List_Permit = 8,
        List_M_Update_Position = 9,
        List_Inner_State_Change_Notify = 10
    }
}
