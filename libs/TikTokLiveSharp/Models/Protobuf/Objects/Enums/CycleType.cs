using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum CycleType
    {
        CycleTypeUnknown = 0,
        CycleTypeFixedTime = 1,
        CycleTypePermanent = 2
    }
}
