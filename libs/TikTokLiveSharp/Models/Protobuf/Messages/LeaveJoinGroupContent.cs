using System.ComponentModel;
using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LeaveJoinGroupContent : AProtoBase
    {
        [ProtoMember(1)]
        public GroupPlayer Operator { get; }

        [ProtoMember(2)]
        public long GroupChannelId { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string LeaveSource { get; } = string.Empty;
    }
}
