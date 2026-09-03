using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubTimerStickerChangeType
    {
        TitleChange = 0,
        StatusChange = 1,
        PositionChange = 2,
        SubIncrease = 3,
        Align = 4
    }
}
