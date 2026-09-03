using System.Collections.Generic;
using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BoostCardMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public List<BoostCard> CardsList { get; } = new List<BoostCard>();
    }
}
