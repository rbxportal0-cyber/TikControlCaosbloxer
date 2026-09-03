using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class OriginBadgeInfo : AProtoBase
    {
        [ProtoMember(1)]
        public int SubLevel { get; }

        [ProtoMember(2)]
        public Image OriginImg { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Description { get; } = string.Empty;
    }
}
