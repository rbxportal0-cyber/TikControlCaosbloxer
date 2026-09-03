using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ProfileContent : AProtoBase
    {
        [ProtoMember(1)]
        public bool UseContent { get; }

        [ProtoMember(2)]
        public List<IconConfig> IconList { get; } = new List<IconConfig>();

        [ProtoMember(3)]
        public NumberConfig NumberConfig { get; }
    }
}
