using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool ShowEntrance { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string SetGoalNotice { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string ManageGoalUrl { get; } = string.Empty;

        [ProtoMember(4)]
        public AuditStatus AuditStatus { get; }

        [ProtoMember(5)]
        public long Target { get; }

        [ProtoMember(6)]
        public long Progress { get; }

        [ProtoMember(8)]
        public GoalSchemaScene GoalSchemaScene { get; }
    }
}
