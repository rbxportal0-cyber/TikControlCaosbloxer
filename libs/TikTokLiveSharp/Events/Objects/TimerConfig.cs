namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TimerConfig
    {
        public readonly int MaxTitleLength;
        public readonly long DefaultStartCountdownTime;
        public readonly long MaxStartCountdownTime;
        public readonly long DefaultTimeIncreasePerSub;
        public readonly long DefaultTimeIncreaseCap;
        public readonly long MaxTimeIncreaseCap;
        public readonly string BottomButtonText;

        private TimerConfig(Models.Protobuf.Objects.TimerConfig config)
        {
            MaxTitleLength = config?.MaxTitleLength ?? -1;
            DefaultStartCountdownTime = config?.DefaultStartCountdownTimeS ?? -1;
            MaxStartCountdownTime = config?.MaxStartCountdownTimeS ?? -1;
            DefaultTimeIncreasePerSub = config?.DefaultTimeIncreasePerSubS ?? -1;
            DefaultTimeIncreaseCap = config?.DefaultTimeIncreaseCapS ?? -1;
            MaxTimeIncreaseCap = config?.MaxTimeIncreaseCapS ?? -1;
            BottomButtonText = config?.BottomButtonText ?? string.Empty;
        }

        public static implicit operator TimerConfig(Models.Protobuf.Objects.TimerConfig config) => new TimerConfig(config);
    }
}
