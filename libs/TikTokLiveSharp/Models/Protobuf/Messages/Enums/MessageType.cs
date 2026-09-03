using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum MessageType
    {
        MessageType_SubSuccess = 0,
        MessageType_AnchorReminder = 1,
        MessageType_EnterRoomExpireSoon = 2,
        MessageType_SubGoalCreateToAnchor = 3,
        MessageType_SubGoalCompleteToAudience = 4,
        MessageType_SubGoalCompleteToAnchor = 5,
        MessageType_SubGiftTikTok2UserNotice = 6,
        MessageType_SubGiftTikTok2AnchorNotice = 7,
        MessageType_SubGiftReceiveSendNotice = 8,
        MessageType_SubGiftSendSucceedRoomMessage = 9,
        MessageType_SubGiftSendSucceedAnchorNotice = 10,
        MessageType_SubGiftLowVersionUpgradeNotice = 11,
        MessageType_SubGiftUserBuyAuthNotice = 12
    }
}
