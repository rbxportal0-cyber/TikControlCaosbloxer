using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubGoalRecommendInfo : AProtoBase
    {
        public enum ExtraCase
        {
            Extra_Not_Set = 0,
            Subscription_Rec_Extra = 4,
            Stream_Goal_Rec_Extra = 5
        }

        public ExtraCase InfoData => (ExtraCase)oneofExtraCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofExtraCase;

        [ProtoMember(1)]
        public SubGoalType Type { get; }

        [ProtoMember(2)]
        public List<SubGoal> ItemsList { get; } = new List<SubGoal>();

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Description { get; } = string.Empty;

        [ProtoMember(4)]
        public SubscriptionGoalRecExtra SubscriptionRecExtra
        {
            get => oneofExtraCase.Is(4) ? (SubscriptionGoalRecExtra)oneofExtraCase.Object : default;
            private set => oneofExtraCase = new DiscriminatedUnion64Object(4, value);
        }

        [ProtoMember(5)]
        public StreamGoalRecExtra StreamGoalRecExtra
        {
            get => oneofExtraCase.Is(5) ? (StreamGoalRecExtra)oneofExtraCase.Object : default;
            private set => oneofExtraCase = new DiscriminatedUnion64Object(5, value);
        }
    }
}
