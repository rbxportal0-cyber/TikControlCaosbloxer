using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum IndicatorOp
    {
        IndicatorOpUnknown = 0,
        IndicatorOpAdd = 1,
        IndicatorOpRemove = 2,
        IndicatorOpUpdate = 3,
        IndicatorOpPin = 4,
        IndicatorOpUnpin = 5
    }
}
