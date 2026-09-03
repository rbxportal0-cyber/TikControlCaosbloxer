using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubBenefitUserConfigStatus
    {
        SubBenefitUserConfigStatusUnknown = 0,
        SubBenefitUserConfigStatusNoNeed = 1,
        SubBenefitUserConfigStatusNeed = 2,
        SubBenefitUserConfigStatusDone = 3
    }
}
