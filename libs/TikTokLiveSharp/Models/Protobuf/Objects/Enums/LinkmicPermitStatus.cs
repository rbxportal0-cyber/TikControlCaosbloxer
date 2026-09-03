using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicPermitStatus
    {
        Linkmic_Permit_Status_None = 0,
        Linkmic_Permit_Status_Agree = 1,
        Linkmic_Permit_Status_Reject = 2
    }
}
