using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum CommunityContentType
    {
        CommunityContentTypeUnknown = 0,
        CommunityContentTypeText = 1,
        CommunityContentTypeImage = 2
    }
}
