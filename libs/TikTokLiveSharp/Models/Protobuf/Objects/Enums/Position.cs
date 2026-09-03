using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum Position
    {
        PositionUnknown = 0,
        PositionLeft = 1,
        PositionRight = 2
    }
}
