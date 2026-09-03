using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SpotlightInfo : AProtoBase
    {
        [ProtoMember(2)]
        public List<SpotlightItem> ItemList { get; } = new List<SpotlightItem>();
    }
}
