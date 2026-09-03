using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkUserState : AProtoBase
    {
        [ProtoMember(1)]
        public Player User { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LinkmicId { get; } = string.Empty;

        [ProtoMember(3)]
        public Position Pos { get; }

        [ProtoMember(4)]
        public long LinkedTimeNano { get; }

        [ProtoMember(5)]
        public OnlineUserState OnlineUserState { get; }

        [ProtoMember(6)]
        public MediaState AudioMuted { get; }

        [ProtoMember(7)]
        public MediaState VideoMuted { get; }

        [ProtoMember(8)]
        public RtcConnectionState RtcConnection { get; }

        [ProtoMember(9)]
        public NetworkState NetworkState { get; }
    }
}
