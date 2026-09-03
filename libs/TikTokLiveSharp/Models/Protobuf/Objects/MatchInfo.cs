using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class MatchInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long Critical { get; }
    }
}
