namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ArrowConfig
    {
        public readonly Picture Icon;

        private ArrowConfig(Models.Protobuf.Objects.ArrowConfig config)
        {
            Icon = config?.Icon;
        }

        public static implicit operator ArrowConfig(Models.Protobuf.Objects.ArrowConfig config) => new ArrowConfig(config);
    }
}
