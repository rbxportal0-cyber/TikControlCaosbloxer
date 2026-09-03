using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkType
    {
        Link_Unknown = 0,
        Audio = 1,
        Video = 2
    }
}
