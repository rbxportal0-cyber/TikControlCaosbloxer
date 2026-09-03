using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubTaskInfo
    {
        public readonly SubUserTask SubUserTask;

        private SubTaskInfo(Models.Protobuf.Objects.SubTaskInfo subTaskInfo)
        {
            SubUserTask = subTaskInfo?.SubUserTask ?? SubUserTask.SubUserTaskUnknown;
        }

        public static implicit operator SubTaskInfo(Models.Protobuf.Objects.SubTaskInfo subTaskInfo) => new SubTaskInfo(subTaskInfo);
    }
}
