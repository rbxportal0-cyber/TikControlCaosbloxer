namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class DSLConfig
    {
        public readonly int SceneVersion;
        public readonly string LayoutId;

        private DSLConfig(Models.Protobuf.LinkmicCommon.DSLConfig config)
        {
            SceneVersion = config?.SceneVersion ?? -1;
            LayoutId = config?.LayoutId ?? string.Empty;
        }

        public static implicit operator DSLConfig(Models.Protobuf.LinkmicCommon.DSLConfig config) => new DSLConfig(config);
    }
}
