using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class NoticeMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(3)]
        public long NoticeType { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Style { get; } = string.Empty;

        [ProtoMember(5)]
        public Text Title { get; }

        [ProtoMember(6)]
        public Text ViolationReason { get; }

        [ProtoMember(7)]
        public Text DisplayText { get; }

        [ProtoMember(8)]
        public Text TipsTitle { get; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string TipsUrl { get; } = string.Empty;

        [ProtoMember(10)]
        public Text NoticeTitle { get; }

        [ProtoMember(11)]
        public Text NoticeContent { get; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string Scene { get; } = string.Empty;
    }
}
