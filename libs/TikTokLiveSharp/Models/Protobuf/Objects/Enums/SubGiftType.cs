using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubGiftType
    {
        UnknownSubGiftType = 0,
        TrayDynamicGift = 1,
        AudioEffectGift = 2,
        Sub_Gift_Type_Banner_Fly_Gift = 3,
        Sub_Gift_Type_Animation_Fly_Gift = 4
    }
}
