namespace TikTokLiveSharp.Events.Objects
{
    public sealed class FlyingMicResources
    {
        public readonly Picture PathImage;
        public readonly Picture MicImage;

        private FlyingMicResources(Models.Protobuf.Objects.FlyingMicResources resources)
        {
            PathImage = resources?.PathImage;
            MicImage = resources?.MicImage;
        }

        public static implicit operator FlyingMicResources(Models.Protobuf.Objects.FlyingMicResources resources) => new FlyingMicResources(resources);
    }
}
