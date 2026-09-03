namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerCancelContent
    {
        public readonly long FromUserId;
        public readonly long ToUserId;
        public readonly long CancelType;
        public readonly long ActionId;

        private LinkerCancelContent(Models.Protobuf.Messages.LinkerCancelContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            ToUserId = content?.ToUserId ?? -1;
            CancelType = content?.CancelType ?? -1;
            ActionId = content?.ActionId ?? -1;
        }

        public static implicit operator LinkerCancelContent(Models.Protobuf.Messages.LinkerCancelContent content) => new LinkerCancelContent(content);
    }
}
