using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TextBadge : AProtoBase
    {
        [ProtoMember(1)]
        public BadgeDisplayType DisplayType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Key { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string DefaultPattern { get; } = string.Empty;

        [ProtoMember(4)]
        public List<string> PiecesList { get; } = new List<string>();
    }
}
