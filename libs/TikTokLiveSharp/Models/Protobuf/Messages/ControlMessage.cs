using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// System-Control Message from Room (e.g. Host ended Stream)
    /// </summary>
    [ProtoContract]
    public partial class ControlMessage : AProtoBase
    {
        [ProtoContract]
        public partial class Extra : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string BanInfoUrl { get; } = string.Empty;

            [ProtoMember(2)]
            public long ReasonNo { get; }

            [ProtoMember(3)]
            public Text Title { get; }

            [ProtoMember(4)]
            public Text ViolationReason { get; }

            [ProtoMember(5)]
            public Text Content { get; }

            [ProtoMember(6)]
            public Text GotItButton { get; }

            [ProtoMember(7)]
            public Text BanDetailButton { get; }

            [ProtoMember(8)]
            [DefaultValue("")]
            public string Source { get; } = string.Empty;
        }

        [ProtoMember(1)]
        public Header Header { get; }
        
        [ProtoMember(2)]
        public ControlAction Action { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Tips { get; } = string.Empty;
        
        [ProtoMember(4)]
        public Extra ExtraData { get; }

        [ProtoMember(5)]
        public PerceptionDialogInfo PerceptionDialog { get; }

        [ProtoMember(6)]
        public Text PerceptionAudienceText { get; }

        [ProtoMember(7)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(8)]
        public Text FloatText { get; }

        [ProtoMember(9)]
        public int FloatStyle { get; }
    }
}
