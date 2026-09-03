namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerAcceptNoticeContent
    {
        public readonly long FromUserId;
        public readonly long FromRoomId;
        public readonly long ToUserId;

        private LinkerAcceptNoticeContent(Models.Protobuf.Messages.LinkerAcceptNoticeContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            FromRoomId = content?.FromRoomId ?? -1;
            ToUserId = content?.ToUserId ?? -1;
        }

        public static implicit operator LinkerAcceptNoticeContent(Models.Protobuf.Messages.LinkerAcceptNoticeContent content) => new LinkerAcceptNoticeContent(content);
    }
}
