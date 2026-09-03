using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCEngineConfig : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string RTCAppId { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string RTCUserId { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string RTCToken { get; } = string.Empty;

        [ProtoMember(4)]
        public long RTCChannelId { get; }
    }
}
