namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerCloseContent
    {
        private LinkerCloseContent(Models.Protobuf.Messages.LinkerCloseContent content)
        {}

        public static implicit operator LinkerCloseContent(Models.Protobuf.Messages.LinkerCloseContent content) => new LinkerCloseContent(content);
    }
}
