using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkType
    {
        Type_Unknown = 0,
        Type_Video = 1,
        Type_Audio = 2,
        Type_Virtual = 3
    }
}
