using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubBenefitConfigStatus
    {
        SubBenefitConfigStatusUnknown = 0,
        SubBenefitConfigStatusNoNeed = 1,
        SubBenefitConfigStatusNeed = 2,
        SubBenefitConfigStatusDone = 3
    }
}
