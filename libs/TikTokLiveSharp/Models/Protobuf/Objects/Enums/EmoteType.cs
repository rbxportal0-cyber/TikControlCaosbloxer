using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EmoteType
    {
        EmoteTypeNormal = 0,
        EmoteTypeWithSticker = 1
    }
}
