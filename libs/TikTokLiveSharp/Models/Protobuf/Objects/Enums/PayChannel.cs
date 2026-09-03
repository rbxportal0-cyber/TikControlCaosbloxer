using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PayChannel
    {
        PayChan_Unknown = 0,
        PayChan_Coins = 1,
        PayChan_IAPCash = 2,
        PayChan_WebApp = 3,
        PayChan_GiftSub = 4
    }
}
