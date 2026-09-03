using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BadgeDisplayType
    {
        BadgeDisplayType_Unknown = 0,
        BadgeDisplayType_Image = 1,
        BadgeDisplayType_Text = 2,
        BadgeDisplayType_String = 3,
        BadgeDisplayType_Combine = 4
    }
}
