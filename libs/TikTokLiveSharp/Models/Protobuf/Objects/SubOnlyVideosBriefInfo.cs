using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubOnlyVideosBriefInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string TotalCountStr { get; } = string.Empty;

        [ProtoMember(2)]
        public int TotalCount { get; }

        [ProtoMember(3)]
        public List<SOVBriefInfo> SOVBriefInfoList { get; } = new List<SOVBriefInfo>();
    }
}
