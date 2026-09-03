using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubPinCard : AProtoBase
    {
        [ProtoContract]
        public partial class Text : AProtoBase
        {
            [System.Serializable]
            [ProtoContract]
            public enum TextType
            {
                UnknownTextType = 0,
                OriginalText = 1,
                StarlingKey = 2
            }

            [ProtoMember(1)]
            public TextType Type { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Content { get; } = string.Empty;
        }

        [ProtoMember(1)]
        public long TimeToLive { get; }

        [ProtoMember(2)]
        public Text Title { get; }

        [ProtoMember(3)]
        public Text Desc { get; }

        [ProtoMember(4)]
        public Image Image { get; }

        [ProtoMember(5)]
        public PinCardType Type { get; }

        [ProtoMember(6)]
        public long Id { get; }

        [ProtoMember(7)]
        public long TemplateId { get; }

        [ProtoMember(8)]
        public SubGoalPinCard GoalPinCard { get; }
    }
}
