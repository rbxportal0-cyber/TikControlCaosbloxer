using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PrivateEmoteDetail : AProtoBase
    {
        [ProtoMember(1)]
        public List<Emote> EmoteList { get; } = new List<Emote>();
    }
}
