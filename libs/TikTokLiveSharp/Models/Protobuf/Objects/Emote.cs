using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Emote : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string EmoteId { get; } = string.Empty;

        [ProtoMember(2)]
        public Image Image { get; }

        [ProtoMember(3)]
        public AuditStatus AuditStatus { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Uuid { get; } = string.Empty;

        [ProtoMember(5)]
        public EmoteType EmoteType { get; }

        [ProtoMember(6)]
        public ContentSource ContentSource { get; }

        [ProtoMember(7)]
        public EmotePrivateType EmotePrivateType { get; }
    }
}
