using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class StringBadge : AProtoBase
    {
        [ProtoMember(1)]
        public BadgeDisplayType DisplayType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Str { get; } = string.Empty;
    }
}
