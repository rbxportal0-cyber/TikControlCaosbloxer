using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ApplyContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Applier { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ApplierLinkMicId { get; } = string.Empty;
    }
}
