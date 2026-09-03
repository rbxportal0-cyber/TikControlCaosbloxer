using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BenefitType
    {
        BenefitTypeUnknown = 0,
        BenefitTypeEmote = 1,
        BenefitTypeBadge = 2,
        BenefitTypeChat = 3,
        BenefitTypeGift = 4
    }
}
