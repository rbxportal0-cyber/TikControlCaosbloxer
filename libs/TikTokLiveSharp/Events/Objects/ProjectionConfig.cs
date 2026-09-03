namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ProjectionConfig
    {
        public readonly bool UseProjection;
        public readonly Picture Icon;

        private ProjectionConfig(Models.Protobuf.Objects.ProjectionConfig config)
        {
            UseProjection = config?.UseProjection ?? false;
            Icon = config?.Icon;
        }

        public static implicit operator ProjectionConfig(Models.Protobuf.Objects.ProjectionConfig config) => new ProjectionConfig(config);
    }
}
