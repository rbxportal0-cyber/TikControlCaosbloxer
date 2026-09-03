using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum VIPPrivilegeDefinition
    {
        VIPPrivilegeDefinition_Unknown = 0,
        VideoBadge = 1,
        LiveBadge = 201,
        RoomNotify = 202,
        VIPSeat = 203,
        VIPRank = 204,
        ExclusiveVIPGift = 205,
        EnterEffect = 206,
        LiveCommentShading = 207,
        ExclusiveCustomerService = 208,
        AllRoomNotify = 209,
        PreventKickoff = 210
    }
}
