namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LastLayoutSetting
    {
        public readonly long Scene;
        public readonly string LayoutId;

        private LastLayoutSetting(Models.Protobuf.Objects.LastLayoutSetting setting)
        {
            Scene = setting?.Scene ?? -1;
            LayoutId = setting?.LayoutId ?? string.Empty;
        }

        public static implicit operator LastLayoutSetting(Models.Protobuf.Objects.LastLayoutSetting setting) => new LastLayoutSetting(setting);
    }
}
