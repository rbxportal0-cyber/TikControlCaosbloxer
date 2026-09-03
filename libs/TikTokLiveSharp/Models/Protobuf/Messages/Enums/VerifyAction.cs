using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum VerifyAction
    {
        UnknowAction = 0, // Typo exists in TikTok's Code
        CloseChat = 3,
        OpenChat = 4,
        ClosedAnmaku = 5,
        OpendAnmaku = 6, // Typo exists in TikTok's Code
        CloseGift = 7,
        OpenGift = 8,
        ClosedIGG = 12,
        OpendIGG = 13, // Typo exists in TikTok's Code
        ChangeTitle = 21,
        ChangeShortTitle = 22,
        ChangeIntroduction = 23,
        CloseBanner = 24,
        OpenBanner = 25,
        OpenAudioChat = 26,
        CloseAudioChat = 27,
        OpenAudioChatAutoPlay = 28,
        CloseAudioChatAutoPly = 29, // Typo exists in TikTok's Code
        OpenRank = 30,
        CloseRank = 31,
        OpenUserCount = 32,
        CloseUserCount = 33,
        OpenViewers = 34,
        CloseViewers = 35,
        OpenChatSubOnly = 36,
        CloseChatSubOnly = 37,
        OpenExplore = 38,
        CloseExplore = 39
    }
}
