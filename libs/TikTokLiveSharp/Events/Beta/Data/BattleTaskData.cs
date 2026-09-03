namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class BattleTaskData
    {
        public readonly uint Data1;

        private BattleTaskData(Models.Protobuf.UnknownObjects.Data.BattleTaskData data)
        {
            Data1 = data?.Data1 ?? 0;
        }

        public static implicit operator BattleTaskData(Models.Protobuf.UnknownObjects.Data.BattleTaskData data) => new BattleTaskData(data);
    }
}
