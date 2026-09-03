using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LikeEffect : AProtoBase
    {
        [ProtoMember(1)]
        public long Version { get; }

        [ProtoMember(2)]
        public long EffectCnt { get; }

        [ProtoMember(3)]
        public long EffectIntervalMs { get; }
    }
}
