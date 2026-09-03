namespace TikTokLiveSharp.Events.Objects
{
    public sealed class IconConfig
    {
        public readonly Picture Icon;
        public readonly CombineBadgeBackground Background;

        private IconConfig(Models.Protobuf.Objects.IconConfig config)
        {
            Icon = config?.Icon;
            Background = config?.Background;
        }

        public static implicit operator IconConfig(Models.Protobuf.Objects.IconConfig config) => new IconConfig(config);
    }
}
