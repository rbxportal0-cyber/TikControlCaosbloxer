using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PerceptionDialogIconType
    {
        IconTypeNone = 0,
        IconTypeWarning = 1,
        IconTypeLinkMic = 2,
        IconTypeGuestLinkMic = 3,
        IconTypeLive = 4,
        IconTypeTreasureBox = 5,
        IconTypeMute = 6,
        IconGamePadAccessRevoked = 7,
        IconTypeBanReportLiveSingleRoom = 8,
        IconTypeBanReportLiveAllRoom = 9,
        IconTypeBanReportLiveGreenScreen = 10,
        IconTypeGift = 11,
        IconTypeAppealSuccess = 12
    }
}
