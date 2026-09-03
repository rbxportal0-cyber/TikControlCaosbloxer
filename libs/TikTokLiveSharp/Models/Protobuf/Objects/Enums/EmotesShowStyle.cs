using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EmotesShowStyle
    {
        EmotesShowStyleNormal = 0,
        EmotesShowStyleWithSticker = 1,
        EmotesShowStyleWithStickerNoPreview = 2
    }
}
