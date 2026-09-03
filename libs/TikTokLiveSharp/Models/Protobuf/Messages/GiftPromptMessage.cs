using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class GiftPromptMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Body { get; } = string.Empty;

        [ProtoMember(4)]
        public int BlockNumDays { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string OrderId { get; } = string.Empty;

        [ProtoMember(6)]
        public long OrderTimestamp { get; }
    }
}
