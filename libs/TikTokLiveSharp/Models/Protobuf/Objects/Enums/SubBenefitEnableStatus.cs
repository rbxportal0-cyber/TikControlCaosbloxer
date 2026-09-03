using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubBenefitEnableStatus
    {
        SubBenefitEnableStatusUnknown = 0,
        SubBenefitEnableStatusEnable = 1,
        SubBenefitEnableStatusPending = 2,
        SubBenefitEnableStatusDisable = 3,
        SubBenefitEnableStatusLackPermission = 10
    }
}
