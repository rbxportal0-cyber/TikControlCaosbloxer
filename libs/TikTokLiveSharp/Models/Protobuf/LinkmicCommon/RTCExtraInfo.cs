using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCExtraInfo : AProtoBase
    {
        [ProtoMember(1)]
        public RTCEngineConfig LiveRTCEngineConfig { get; }

        [ProtoMember(2)]
        public List<RTCLiveVideoParam> LiveRTCVideoParamList { get; } = new List<RTCLiveVideoParam>();

        [ProtoMember(3)]
        public RTCBitrateMap RTCBitrateMap { get; }

        [ProtoMember(4)]
        public int RTCFps { get; }

        [ProtoMember(5)]
        public RTCMixBase RTCMixBase { get; }

        [ProtoMember(6)]
        public ByteRTCExtInfo ByteRTCExtInfo { get; }

        [ProtoMember(7)]
        public RTCInfoExtra Extra { get; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string RTCBusinessId { get; } = string.Empty;

        [ProtoMember(9)]
        public RTCOther RTCOther { get; }

        [ProtoMember(10)]
        public int InteractClientType { get; }
    }
}
