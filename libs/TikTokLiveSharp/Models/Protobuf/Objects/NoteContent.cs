using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class NoteContent : AProtoBase
    {
        [ProtoMember(1)]
        public NoteContentType NoteContentType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string NoteContentText { get; } = string.Empty;

        [ProtoMember(3)]
        public Image NoteContentImage { get; }

        [ProtoMember(4)]
        public int NoteContentDisplayOrder { get; }

        [ProtoMember(5)]
        public long NoteTimeMs { get; }
    }
}
