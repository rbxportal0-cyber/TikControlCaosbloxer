using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkCommon : AProtoBase
    {
        [ProtoMember(1)]
        public int Scene { get; }

        [ProtoMember(200)]
        [DefaultValue("")]
        public string Source { get; } = string.Empty;

        [ProtoMember(201)]
        public long AppId { get; }

        [ProtoMember(202)]
        public long LiveId { get; }

        [ProtoMember(203)]
        public Dictionary<string, string> ExtraMap { get; } = new Dictionary<string, string>();
    }
}
