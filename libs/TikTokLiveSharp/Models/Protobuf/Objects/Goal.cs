using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Goal : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }
        
        [ProtoMember(2)]
        public GoalType Type { get; }
        
        [ProtoMember(3)]
        public GoalStatus Status { get; }

        [ProtoMember(4)]
        public List<SubGoal> SubGoalsList { get; } = new List<SubGoal>();

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Description { get; } = string.Empty;

        [ProtoMember(6)]
        public int AuditStatus { get; }
        
        [ProtoMember(7)]
        public CycleType CycleType { get; }

        [ProtoMember(8)]
        public long StartTime { get; }

        [ProtoMember(9)]
        public long ExpireTime { get; }

        [ProtoMember(10)]
        public long RealFinishTime { get; }

        [ProtoMember(11)]
        public List<GoalContributor> ContributorsList { get; } = new List<GoalContributor>();

        [ProtoMember(12)]
        public int ContributorsLength { get; }

        [ProtoMember(13)]
        [DefaultValue("")]
        public string IdStr { get; } = string.Empty;

        [ProtoMember(14)]
        [DefaultValue("")]
        public string AuditDescription { get; } = string.Empty;

        [ProtoMember(15)]
        public GoalStats Stats { get; }
    }
}
