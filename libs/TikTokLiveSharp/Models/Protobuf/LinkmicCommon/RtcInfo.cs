using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class RtcInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Info { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LinkMicId { get; } = string.Empty;
    }
}
