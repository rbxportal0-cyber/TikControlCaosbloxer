using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class RollCfg : AProtoBase
    {
        [ProtoMember(1)] 
        public long Weight { get; }

        [ProtoMember(2)]
        public long Duration { get; }
    }
}