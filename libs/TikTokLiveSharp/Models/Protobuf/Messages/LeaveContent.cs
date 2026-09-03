using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LeaveContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Leaver { get; }

        [ProtoMember(2)]
        public long LeaveReason { get; }
    }
}
