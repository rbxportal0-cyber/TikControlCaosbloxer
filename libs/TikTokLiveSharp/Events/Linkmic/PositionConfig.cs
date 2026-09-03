namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class PositionConfig
    {
        public readonly int MaxPosition;

        private PositionConfig(Models.Protobuf.LinkmicCommon.PositionConfig config)
        {
            MaxPosition = config?.MaxPosition ?? -1;
        }

        public static implicit operator PositionConfig(Models.Protobuf.LinkmicCommon.PositionConfig config) => new PositionConfig(config);
    }
}
