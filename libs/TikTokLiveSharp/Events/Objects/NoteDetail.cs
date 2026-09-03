using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class NoteDetail
    {
        public readonly IReadOnlyList<NoteContent> Contents;
        public readonly long Version;

        private NoteDetail(Models.Protobuf.Objects.NoteDetail noteDetail)
        {
            Contents = noteDetail?.NoteContentList?.Count > 0 ? noteDetail.NoteContentList.Select(c => (NoteContent)c).ToList().AsReadOnly() : new List<NoteContent>(0).AsReadOnly();
            Version = noteDetail?.NoteVersion ?? -1;
        }

        public static implicit operator NoteDetail(Models.Protobuf.Objects.NoteDetail noteDetail) => new NoteDetail(noteDetail);
    }
}
