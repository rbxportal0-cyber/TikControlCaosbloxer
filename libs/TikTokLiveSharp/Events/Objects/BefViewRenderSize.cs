namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BefViewRenderSize
    {
        public readonly int Width;
        public readonly int Height;

        private BefViewRenderSize(Models.Protobuf.Objects.BefViewRenderSize renderSize)
        {
            Width = renderSize?.Width ?? -1;
            Height = renderSize?.Height ?? -1;
        }

        public static implicit operator BefViewRenderSize(Models.Protobuf.Objects.BefViewRenderSize renderSize) => new BefViewRenderSize(renderSize);
    }
}
