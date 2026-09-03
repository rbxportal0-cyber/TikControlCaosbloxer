namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SeparatorConfig
    {
        public readonly string Color;

        private SeparatorConfig(Models.Protobuf.Objects.SeparatorConfig config)
        {
            Color = config?.Color ?? string.Empty;
        }

        public static implicit operator SeparatorConfig(Models.Protobuf.Objects.SeparatorConfig config) => new SeparatorConfig(config);
    }
}
