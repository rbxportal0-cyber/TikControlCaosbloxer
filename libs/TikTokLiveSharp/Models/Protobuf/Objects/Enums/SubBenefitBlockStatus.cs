using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubBenefitBlockStatus
    {
        SubBenefitBlockStatusUnblock = 0,
        SubBenefitBlockStatusByShark = 1
    }
}
