using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum DetailBlockReason
    {
        BlockReasonNone = 0,
        InLinkMic = 100,
        MultiHostFull = 101,
        InCohostLinkMic = 102,
        DealOtherInvite = 103,
        DealOtherApply = 104,
        InPkStatus = 105,
        SelfInPkStatus = 106,
        InCohostInviteApply = 107,
        InAudienceLinkMic = 108,
        WaitingAutoMatch = 109,
        InviteNeedToJoin = 110,
        JoinNeedToInvite = 111,
        NoLinkMicPermission = 200,
        AnchorLinkMicSettingClosed = 202,
        AnchorLinkMicRefuseNotFollower = 203,
        AnchorLinkMicBlockInvitationOfLive = 204,
        AnchorLinkMicRefuseFriendInvite = 205,
        AnchorLinkMicRefuseFriendApply = 206,
        AnchorLinkMicRefuseNotFriendInvite = 207,
        AnchorLinkMicRefuseNotFriendApply = 208,
        AnchorLinkMicBlockInvitationOfMultiHost = 209,
        AnchorLinkMicBlockApplyOfMultiHost = 210,
        RoomPaused = 300,
        LiveTypeAudio = 301,
        RoomInteractionConflict = 302,
        RivalVersionNotSupport = 303,
        SelfVersionNotSupport = 304,
        MatureThemeMismatch = 305,
        SelfInOfficialChannel = 306,
        RivalInOfficialChannel = 307,
        InOfficialBackupChannel = 308,
        RivalReserveFull = 309,
        AnchorNotLiving = 310,
        AnchorIsSelf = 311,
        PrivateRoom = 312,
        BlockedByRival = 313,
        SelfBlockedRival = 314,
        ViewerRegionNotSupport = 315,
        SubscriberRoom = 316,
        RegionalBlock = 317,
        NetworkError = 400,
        RoomFilterError = 401
    }
}
