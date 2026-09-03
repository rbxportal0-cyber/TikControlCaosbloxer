namespace TikTokLiveSharp.Events.Objects
{
    public sealed class VoteUser
    {
        public readonly long UserId;
        public readonly string NickName;
        public readonly Picture AvatarThumb;

        private VoteUser(Models.Protobuf.Objects.VoteUser response)
        {
            UserId = response?.UserId ?? -1;
            NickName = response?.NickName ?? string.Empty;
            AvatarThumb = response?.AvatarThumb;
        }

        public static implicit operator VoteUser(Models.Protobuf.Objects.VoteUser response) => new VoteUser(response);
    }
}
