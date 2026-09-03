using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerRandomMatchContent
    {
        public readonly User User;
        public readonly long RoomId;
        public readonly long InviteType;
        public readonly string MatchId;
        public readonly long InnerChannelId;

        private LinkerRandomMatchContent(Models.Protobuf.Messages.LinkerRandomMatchContent content)
        {
            User = content?.User;
            RoomId = content?.RoomId ?? -1;
            InviteType = content?.InviteType ?? -1;
            MatchId = content?.MatchId ?? string.Empty;
            InnerChannelId = content?.InnerChannelId ?? -1;
        }

        public static implicit operator LinkerRandomMatchContent(Models.Protobuf.Messages.LinkerRandomMatchContent content) => new LinkerRandomMatchContent(content);
    }
}
