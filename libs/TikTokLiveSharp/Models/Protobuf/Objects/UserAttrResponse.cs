using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class UserAttrResponse : AProtoBase
    {
        [ProtoMember(1)]
        public Dictionary<long, long> Values { get; } = new Dictionary<long, long>();
    }
}
