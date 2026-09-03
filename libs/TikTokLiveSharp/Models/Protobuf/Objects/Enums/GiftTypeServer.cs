using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GiftTypeServer
    {
        UnknownGiftType = 0,
        SmallGiftType = 1,
        BigGiftType = 2,
        LuckyMoneyGiftType = 3,
        FaceRecognitionGiftType = 4
    }
}
