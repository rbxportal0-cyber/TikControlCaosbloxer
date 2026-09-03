using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PinStatus
    {
        Pin_Status_Unknown = 0,
        Pin_Status_Active = 1,
        Pin_Status_Cooling_Down = 2,
        Pin_Status_Can_Pin = 3
    }
}
