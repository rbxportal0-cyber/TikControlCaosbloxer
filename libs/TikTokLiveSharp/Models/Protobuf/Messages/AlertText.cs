using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class AlertText : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public int AlertType { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Text { get; } = string.Empty;

        [ProtoMember(4)]
        public AuditStatus AuditStatus { get; }
    }
}
