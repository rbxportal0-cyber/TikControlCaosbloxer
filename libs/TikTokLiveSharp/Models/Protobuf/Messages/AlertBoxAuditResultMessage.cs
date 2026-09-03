using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class AlertBoxAuditResultMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long UserId { get; }

        [ProtoMember(3)]
        public List<AlertImage> ImageList { get; } = new List<AlertImage>();

        [ProtoMember(4)]
        public List<AlertText> TextList { get; } = new List<AlertText>();

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Scene { get; } = string.Empty;

        [ProtoMember(6)]
        public List<AlertAudio> AudioList { get; } = new List<AlertAudio>();
    }
}
