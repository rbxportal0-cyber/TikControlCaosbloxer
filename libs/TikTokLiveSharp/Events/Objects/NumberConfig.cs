namespace TikTokLiveSharp.Events.Objects
{
    public sealed class NumberConfig
    {
        public readonly long Number;
        public readonly FontStyle FontStyle;
        public readonly CombineBadgeBackground Background;

        private NumberConfig(Models.Protobuf.Objects.NumberConfig config)
        {
            Number = config?.Number ?? -1;
            FontStyle = config?.FontStyle;
            Background = config?.Background;
        }

        public static implicit operator NumberConfig(Models.Protobuf.Objects.NumberConfig config) => new NumberConfig(config);
    }
}
