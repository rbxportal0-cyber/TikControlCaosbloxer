using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkPosition : AProtoBase
    {
        [ProtoMember(1)]
        public int Position { get; }

        [ProtoMember(2)]
        public int Opt { get; }
    }
}
