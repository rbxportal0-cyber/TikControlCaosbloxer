using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ContentSource
    {
        ContentSourceUnknown = 0,
        ContentSourceNormal = 1,
        ContentSourceCamera = 2
    }
}
