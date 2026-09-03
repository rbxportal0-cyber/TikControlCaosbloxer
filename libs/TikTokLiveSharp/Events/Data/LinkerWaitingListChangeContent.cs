namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerWaitingListChangeContent
    {
        private LinkerWaitingListChangeContent(Models.Protobuf.Messages.LinkerWaitingListChangeContent content)
        {}

        public static implicit operator LinkerWaitingListChangeContent(Models.Protobuf.Messages.LinkerWaitingListChangeContent content) => new LinkerWaitingListChangeContent(content);
    }
}
