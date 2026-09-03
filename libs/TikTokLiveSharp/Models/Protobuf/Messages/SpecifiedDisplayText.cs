using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SpecifiedDisplayText : AProtoBase
    {
        [ProtoMember(1)]
        public long Uid { get; }

        [ProtoMember(2)]
        public Text DisplayText { get; }
    }
}
