using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkBaseResp : AProtoBase
    {
        [ProtoMember(1)]
        public long ErrCode { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ErrMsg { get; } = string.Empty;

        [ProtoMember(3)]
        public Dictionary<string, byte[]> ExtraMap { get; } = new Dictionary<string, byte[]>();
    }
}
