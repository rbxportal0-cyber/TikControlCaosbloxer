namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CohostABTestSetting
    {
        public readonly long Key;
        public readonly CohostABTestList Value;

        private CohostABTestSetting(Models.Protobuf.Objects.CohostABTestSetting setting)
        {
            Key = setting?.Key ?? -1;
            Value = setting?.Value;
        }

        public static implicit operator CohostABTestSetting(Models.Protobuf.Objects.CohostABTestSetting setting) => new CohostABTestSetting(setting);
    }
}
