using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class NoteContent
    {
        public readonly NoteContentType Type;
        public readonly string Text;
        public readonly Picture Image;
        public readonly int DisplayOrder;
        public readonly long TimeMs;

        private NoteContent(Models.Protobuf.Objects.NoteContent noteContent)
        {
            Type = noteContent?.NoteContentType ?? NoteContentType.NoteContentTypeUnknown;
            Text = noteContent?.NoteContentText ?? string.Empty;
            Image = noteContent?.NoteContentImage;
            DisplayOrder = noteContent?.NoteContentDisplayOrder ?? -1;
            TimeMs = noteContent?.NoteTimeMs ?? -1;
        }

        public static implicit operator NoteContent(Models.Protobuf.Objects.NoteContent noteContent) => new NoteContent(noteContent);
    }
}
