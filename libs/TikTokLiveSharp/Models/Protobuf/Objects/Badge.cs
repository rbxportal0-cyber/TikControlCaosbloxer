using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Badge : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string BadgeAbbr { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string BadgeDesc { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string BadgeEmoji { get; } = string.Empty;

        [ProtoMember(4)]
        public Image BadgeIcon { get; }

        [ProtoMember(5)]
        public BadgeType BadgeType { get; }

        [ProtoMember(6)]
        public long BadgeId { get; }
    }
}
