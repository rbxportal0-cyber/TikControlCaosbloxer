using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CommentQualityScore : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Version { get; } = string.Empty;

        [ProtoMember(2)]
        public long Score { get; }
    }
}
