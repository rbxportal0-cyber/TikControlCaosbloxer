using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerSysKickOutContent : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;
    }
}
