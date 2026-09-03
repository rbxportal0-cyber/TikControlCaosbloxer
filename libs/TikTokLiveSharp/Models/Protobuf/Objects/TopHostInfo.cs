using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TopHostInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string RankType { get; } = string.Empty;

        [ProtoMember(2)]
        public long TopIndex { get; }
    }
}
