namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerCreateContent
    {
        public readonly long OwnerId;
        public readonly long OwnerRoomId;
        public readonly long LinkType;

        private LinkerCreateContent(Models.Protobuf.Messages.LinkerCreateContent content)
        {
            OwnerId = content?.OwnerId ?? -1;
            OwnerRoomId = content?.OwnerRoomId ?? -1;
            LinkType = content?.LinkType ?? -1;
        }

        public static implicit operator LinkerCreateContent(Models.Protobuf.Messages.LinkerCreateContent content) => new LinkerCreateContent(content);
    }
}
