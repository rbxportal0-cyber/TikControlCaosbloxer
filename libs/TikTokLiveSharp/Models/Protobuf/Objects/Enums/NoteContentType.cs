using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum NoteContentType
    {
        NoteContentTypeUnknown = 0,
        NoteContentTypeText = 1,
        NoteContentTypeImage = 2,
        NoteContentTypeImageCombined = 3
    }
}
