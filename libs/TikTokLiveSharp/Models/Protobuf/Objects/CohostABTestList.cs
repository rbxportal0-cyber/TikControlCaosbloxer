using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CohostABTestList : AProtoBase
    {
        [ProtoMember(1)]
        public List<CohostABTest> ABTestList { get; } = new List<CohostABTest>();
    }
}
