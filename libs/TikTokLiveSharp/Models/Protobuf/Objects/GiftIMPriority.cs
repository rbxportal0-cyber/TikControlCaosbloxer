using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftIMPriority : AProtoBase
    {
        [ProtoMember(1)]
        public List<long> QueueSizesList { get; } = new List<long>();

        [ProtoMember(2)]
        public long SelfQueuePriority { get; }

        [ProtoMember(3)]
        public long Priority { get; }
    }
}
