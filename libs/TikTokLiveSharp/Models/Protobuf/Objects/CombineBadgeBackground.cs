using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CombineBadgeBackground : AProtoBase
    {
        [ProtoMember(1)]
        public Image Image { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string BackgroundColorCode { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string BorderColorCode { get; } = string.Empty;
    }
}
