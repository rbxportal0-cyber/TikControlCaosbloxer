using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class InviteTopHostInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string RankType { get; } = string.Empty;

        [ProtoMember(2)]
        public long TopIndex { get; }
    }
}
