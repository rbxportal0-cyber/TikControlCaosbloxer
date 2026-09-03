using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PayStatus
    {
        SubStatus_Unknown = 0,
        SubStatus_OneTime = 1,
        SubStatus_AutoDeduction = 2,
        SubStatus_AutoDeductionCanceled = 3,
        SubStatus_Revoke = 4
    }
}
