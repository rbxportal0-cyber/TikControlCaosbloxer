namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextPieceUser
    {
        public readonly User User;

        public readonly bool WithColon;

        private TextPieceUser(Models.Protobuf.Objects.TextPieceUser user)
        {
            User = user?.User;
            WithColon = user?.WithColon ?? false;
        }

        public static implicit operator TextPieceUser(Models.Protobuf.Objects.TextPieceUser textPieceUser) => new TextPieceUser(textPieceUser);
    }
}
