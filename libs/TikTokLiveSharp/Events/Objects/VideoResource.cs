namespace TikTokLiveSharp.Events.Objects
{
    public sealed class VideoResource
    {
        public readonly string VideoTypeName;

        public readonly Picture VideoUrl;

        public readonly string VideoMd5;

        private VideoResource(Models.Protobuf.Objects.VideoResource videoResource)
        {
            VideoTypeName = videoResource?.VideoTypeName ?? string.Empty;
            VideoUrl = videoResource?.VideoUrl;
            VideoMd5 = videoResource?.VideoMd5 ?? string.Empty;
        }

        public static implicit operator VideoResource(Models.Protobuf.Objects.VideoResource videoResource) => new VideoResource(videoResource);
    }
}
