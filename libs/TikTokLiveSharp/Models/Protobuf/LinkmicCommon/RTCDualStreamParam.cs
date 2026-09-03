using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCDualStreamParam : AProtoBase
    {
        [ProtoMember(1)]
        public int RemoteDefaultStreamType { get; }

        [ProtoMember(2)]
        public int IsAutoSwitch { get; }

        [ProtoMember(3)]
        public int AutoSwitchUserNum { get; }

        [ProtoMember(4)]
        public RTCVideoParam HdVideoParam { get; }

        [ProtoMember(5)]
        public RTCVideoParam SdVideoParam { get; }
    }
}
