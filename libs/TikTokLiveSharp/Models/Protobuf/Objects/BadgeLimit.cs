using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgeLimit : AProtoBase
    {
        [ProtoMember(1)]
        public int AbbrCharCntLmt { get; }

        [ProtoMember(2)]
        public int DescCharCntLmt { get; }
    }
}
