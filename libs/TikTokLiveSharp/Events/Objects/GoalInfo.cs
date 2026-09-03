using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GoalInfo
    {
        public readonly bool ShowEntrance;
        public readonly string SetGoalNotice;
        public readonly string ManageGoalUrl;
        public readonly AuditStatus AuditStatus;
        public readonly long Target;
        public readonly long Progress;
        public readonly GoalSchemaScene GoalSchemaScene;

        private GoalInfo(Models.Protobuf.Objects.GoalInfo info)
        {
            ShowEntrance = info?.ShowEntrance ?? false;
            SetGoalNotice = info?.SetGoalNotice ?? string.Empty;
            ManageGoalUrl = info?.ManageGoalUrl ?? string.Empty;
            AuditStatus = info?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
            Target = info?.Target ?? -1;
            Progress = info?.Progress ?? -1;
            GoalSchemaScene = info?.GoalSchemaScene ?? GoalSchemaScene.GoalSchemaUnknown;
        }

        public static implicit operator GoalInfo(Models.Protobuf.Objects.GoalInfo info) => new GoalInfo(info);
    }
}
