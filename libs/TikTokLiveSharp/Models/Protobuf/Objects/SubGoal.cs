using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubGoal : AProtoBase
    {
        public enum ExtraCase
        {
            Extra_Not_Set = 0,
            Gift = 5
        }

        public ExtraCase GiftData => (ExtraCase)oneofExtraCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofExtraCase;


        [ProtoMember(1)]
        public SubGoalType Type { get; }

        [ProtoMember(2)]
        public long Id { get; }

        [ProtoMember(3)]
        public long Progress { get; }

        [ProtoMember(4)]
        public long Target { get; }

        [ProtoMember(5)]
        public GiftSubGoal Gift
        {
            get => oneofExtraCase.Is(5) ? (GiftSubGoal)oneofExtraCase.Object : default;
            private set => oneofExtraCase = new DiscriminatedUnion64Object(5, value);
        }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string IdStr { get; } = string.Empty;
    }
}
