using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GiftVerticalScenario
    {
        UnknownGiftVerticalScenario = 0,
        LokiGift = 1,
        LynxGift = 2,
        GiftBox = 3,
        RandomTravelGift = 4,
        ColorGift = 5,
        InGiftBoxGift = 6
    }
}
