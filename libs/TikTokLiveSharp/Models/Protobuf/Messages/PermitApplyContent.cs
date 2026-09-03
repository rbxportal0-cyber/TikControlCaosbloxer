using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PermitApplyContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Permiter { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string PermiterLinkMicId { get; } = string.Empty;

        [ProtoMember(3)]
        public Position ApplierPos { get; }

        [ProtoMember(4)]
        public ReplyStatus ReplyStatus { get; }

        [ProtoMember(5)]
        public DSLConfig Dsl { get; }

        [ProtoMember(6)]
        public Player Applier { get; }

        [ProtoMember(7)]
        public Player Operator { get; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string ApplierLinkMicId { get; } = string.Empty;
    }
}
