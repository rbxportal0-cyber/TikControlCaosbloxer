namespace TikTokLiveSharp.Events.Objects
{
    public sealed class RollCfg
    {
        public readonly long Weight;
        public readonly long Duration;

        private RollCfg(Models.Protobuf.Objects.RollCfg config)
        {
            Weight = config?.Weight ?? -1;
            Duration = config?.Duration ?? -1;
        }

        public static implicit operator RollCfg(Models.Protobuf.Objects.RollCfg config) => new RollCfg(config);
    }
}
