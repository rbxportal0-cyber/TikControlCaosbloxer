using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PinCardType
    {
        UnknownPinCardType = 0,
        CustomizedBenefitEnum = 1,
        SubGoalEnum = 2
    }
}
