using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CombineBadge : AProtoBase
    {
        [ProtoMember(1)]
        public BadgeDisplayType DisplayType { get; }

        [ProtoMember(2)]
        public Image Icon { get; }

        [ProtoMember(3)]
        public BadgeText Text { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Str { get; } = string.Empty;

        [ProtoMember(5)]
        public PaddingInfo Padding { get; }

        [ProtoMember(6)]
        public FontStyle FontStyle { get; }

        [ProtoMember(7)]
        public ProfileCardPanel ProfileCardPanel { get; }

        [ProtoMember(11)]
        public CombineBadgeBackground Background { get; }

        [ProtoMember(12)]
        public CombineBadgeBackground BackgroundDarkMode { get; }

        [ProtoMember(13)]
        public bool IconAutoMirrored { get; }

        [ProtoMember(14)]
        public bool BackgroundAutoMirrored { get; }

        [ProtoMember(15)]
        public int PublicScreenShowStyle { get; }

        [ProtoMember(16)]
        public int PersonalCardShowStyle { get; }

        [ProtoMember(17)]
        public int RankListOnlineAudienceShowStyle { get; }

        [ProtoMember(18)]
        public int MultiGuestShowStyle { get; }

        [ProtoMember(19)]
        public ArrowConfig ArrowConfig { get; }

        [ProtoMember(20)]
        public PaddingInfo PaddingNewFont { get; }
    }
}
