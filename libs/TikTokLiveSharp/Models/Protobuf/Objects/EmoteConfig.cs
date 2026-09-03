using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class EmoteConfig : AProtoBase
    {
        [ProtoMember(1)]
        public int EmoteCntLmt { get; }

        [ProtoMember(2)]
        public List<Emote> DefaultEmoteList { get; } = new List<Emote>();
    }
}
