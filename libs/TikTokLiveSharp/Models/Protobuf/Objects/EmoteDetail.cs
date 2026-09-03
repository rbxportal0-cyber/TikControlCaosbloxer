using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class EmoteDetail : AProtoBase
    {
        [ProtoMember(1)]
        public List<Emote> EmoteList { get; } = new List<Emote>();

        [ProtoMember(2)]
        public bool Exist { get; }

        [ProtoMember(3)]
        public long EmoteVersion { get; }
    }
}
