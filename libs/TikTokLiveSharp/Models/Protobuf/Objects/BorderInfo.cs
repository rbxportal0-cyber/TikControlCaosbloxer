using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BorderInfo : AProtoBase
    {
        [ProtoMember(1)]
        public Image Icon { get; }

        [ProtoMember(2)]
        public long Level { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Source { get; } = string.Empty;

        [ProtoMember(4)]
        public Image ProfileDecorationRibbon { get; }

        [ProtoMember(5)]
        public PrivilegeLogExtra BorderPrivilegeLogExtra { get; }

        [ProtoMember(6)]
        public PrivilegeLogExtra ProfilePrivilegeLogExtra { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string AvatarBackgroundColor { get; } = string.Empty;

        [ProtoMember(8)]
        public string AvatarBackgroundBorderColor { get; } = string.Empty;
    }
}
