namespace TikTokLiveSharp.Events.Objects
{
    public sealed class DiggIcon
    {
        public readonly long Id;
        public readonly Picture NormalIconUrl;

        private DiggIcon(Models.Protobuf.Objects.DiggIcon icon)
        {
            Id = icon?.Id ?? -1;
            NormalIconUrl = icon?.NormalIconUrl;
        }

        public static implicit operator DiggIcon(Models.Protobuf.Objects.DiggIcon icon) => new DiggIcon(icon);
    }
}
