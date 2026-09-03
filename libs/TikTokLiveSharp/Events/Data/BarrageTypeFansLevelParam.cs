using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class BarrageTypeFansLevelParam
    {
        public readonly int CurrentGrade;
        public readonly int DisplayConfig;
        public readonly User User;

        private BarrageTypeFansLevelParam(Models.Protobuf.Messages.BarrageTypeFansLevelParam barrageLevelParam)
        {
            CurrentGrade = barrageLevelParam?.CurrentGrade ?? -1;
            DisplayConfig = barrageLevelParam?.DisplayConfig ?? -1;
            User = barrageLevelParam?.User;
        }

        public static implicit operator BarrageTypeFansLevelParam(Models.Protobuf.Messages.BarrageTypeFansLevelParam barrageLevelParam) => new BarrageTypeFansLevelParam(barrageLevelParam);
    }
}
