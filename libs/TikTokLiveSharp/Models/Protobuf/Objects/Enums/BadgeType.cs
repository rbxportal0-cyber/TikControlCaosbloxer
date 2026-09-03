using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BadgeType
    {
        BadgeTypeNormal = 0,
        BadgeTypeEmoji = 1,
        BadgeTypePlatformIcon = 2
    }
}
