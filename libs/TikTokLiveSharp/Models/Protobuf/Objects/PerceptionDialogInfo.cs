using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PerceptionDialogInfo : AProtoBase
    {
        [ProtoMember(1)] 
        public PerceptionDialogIconType IconType { get; }

        [ProtoMember(2)]
        public Text Title { get; }

        [ProtoMember(3)]
        public Text SubTitle { get; }

        [ProtoMember(4)]
        public Text AdviceActionText { get; }

        [ProtoMember(5)]
        public Text DefaultActionText { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string ViolationDetailUrl { get; } = string.Empty;

        [ProtoMember(7)]
        public int Scene { get; }

        [ProtoMember(8)]
        public long TargetUserId { get; }

        [ProtoMember(9)]
        public long TargetRoomId { get; }

        [ProtoMember(10)]
        public long CountDownTime { get; }

        [ProtoMember(11)]
        public bool ShowFeedback { get; }

        [ProtoMember(12)]
        public List<PerceptionFeedbackOption> FeedbackOptionsList { get; } = new List<PerceptionFeedbackOption>();

        [ProtoMember(13)]
        public long PolicyTip { get; }
    }
}
