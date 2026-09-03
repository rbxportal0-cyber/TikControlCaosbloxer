using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class GoalUpdateMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public Indicator Indicator { get; }

        [ProtoMember(3)]
        public Goal Goal { get; }

        [ProtoMember(4)]
        public long ContributorId { get; }

        [ProtoMember(5)]
        public Image ContributorAvatar { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string ContributorDisplayId { get; } = string.Empty;

        [ProtoMember(7)]
        public SubGoal SubGoal { get; }

        [ProtoMember(9)]
        public long ContributeCount { get; }

        [ProtoMember(10)]
        public long ContributeScore { get; }

        [ProtoMember(11)]
        public long GiftRepeatCount { get; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string ContributorIdStr { get; } = string.Empty;

        [ProtoMember(13)]
        public bool Pin { get; }

        [ProtoMember(14)]
        public bool Unpin { get; }

        [ProtoMember(15)]
        public GoalPinInfo PinInfo { get; }
    }
}
