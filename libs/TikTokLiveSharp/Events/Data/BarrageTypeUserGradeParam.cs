using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class BarrageTypeUserGradeParam
    {
        public readonly int CurrentGrade;
        public readonly int DisplayConfig;
        public readonly string UserId;
        public readonly User User;

        private BarrageTypeUserGradeParam(Models.Protobuf.Messages.BarrageTypeUserGradeParam barrageUserParam)
        {
            CurrentGrade = barrageUserParam?.CurrentGrade ?? -1;
            DisplayConfig = barrageUserParam?.DisplayConfig ?? -1;
            UserId = barrageUserParam?.UserId ?? string.Empty;
            User = barrageUserParam?.User;
        }

        public static implicit operator BarrageTypeUserGradeParam(Models.Protobuf.Messages.BarrageTypeUserGradeParam barrageUserParam) => new BarrageTypeUserGradeParam(barrageUserParam);
    }
}
