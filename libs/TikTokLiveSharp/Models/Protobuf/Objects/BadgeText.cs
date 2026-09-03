using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgeText : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string DefaultPattern { get; } = string.Empty;

        [ProtoMember(3)]
        public List<string> PiecesList { get; } = new List<string>();
    }
}
