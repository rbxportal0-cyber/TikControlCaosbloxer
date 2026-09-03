using System.Collections.Generic;
using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TopFrameSummary : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Schema { get; } = string.Empty;

        [ProtoMember(4)]
        public List<ShowInfo> ShowList { get; } = new List<ShowInfo>();
    }
}
