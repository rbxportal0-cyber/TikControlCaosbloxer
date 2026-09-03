using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class StateReqCommon : AProtoBase
    {
        [ProtoMember(1)]
        public int Scene { get; }

        [ProtoMember(2)]
        public long AppId { get; }

        [ProtoMember(3)]
        public long LiveId { get; }

        [ProtoMember(4)]
        public Player Myself { get; }

        [ProtoMember(5)]
        public long ChannelId { get; }
    }
}
