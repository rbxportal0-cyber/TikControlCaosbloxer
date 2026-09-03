using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class VIPBadge : AProtoBase
    {
        [ProtoMember(1)]
        public Dictionary<long, Image> IconsMap { get; } = new Dictionary<long, Image>();
    }
}
