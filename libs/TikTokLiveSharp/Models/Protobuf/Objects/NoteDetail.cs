using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class NoteDetail : AProtoBase
    {
        [ProtoMember(1)]
        public List<NoteContent> NoteContentList { get; } = new List<NoteContent>();

        [ProtoMember(2)]
        public long NoteVersion { get; }
    }
}
