using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicAudienceType
    {
        Audience_Type_Unknown = 0,
        Video = 1,
        Audio = 2
    }
}
