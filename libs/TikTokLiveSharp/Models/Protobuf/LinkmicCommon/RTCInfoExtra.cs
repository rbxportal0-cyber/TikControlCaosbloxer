using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RTCInfoExtra : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Version { get; } = string.Empty;
    }
}
