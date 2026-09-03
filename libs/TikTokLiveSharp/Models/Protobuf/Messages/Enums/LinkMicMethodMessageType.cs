using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkMicMethodMessageType
    {
        Type_None = 0,
        Type_TurnOn = 1,
        Type_Permit = 2,
        Type_KickOuted = 3,
        Type_Finish = 4,
        Type_Waiting_List_Changed = 5,
        Type_Linked_List_Changed = 6,
        Type_All_List_Changed = 7,
        Type_Fan_Ticket_Changed = 8,
        Type_Ranking_Update = 9,
        Type_Silence = 10,
        Type_Unsilence = 11,
        Type_Invite = 12,
        Type_Reply = 13,
        Type_Auto_Join = 14,
        Type_Agree_Admin_First_Invite = 15
    }
}
