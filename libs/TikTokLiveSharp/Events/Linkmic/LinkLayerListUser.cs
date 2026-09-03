namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkLayerListUser
    {
        public readonly Player User;
        public readonly string LinkmicId;
        public readonly Position Pos;
        public readonly long LinkedTimeNano;
        public readonly string AppVersion;

        private LinkLayerListUser(Models.Protobuf.LinkmicCommon.LinkLayerListUser user)
        {
            User = user?.User;
            LinkmicId = user?.LinkmicId ?? string.Empty;
            Pos = user?.Pos;
            LinkedTimeNano = user?.LinkedTimeNano ?? -1;
            AppVersion = user?.AppVersion ?? string.Empty;
        }

        public static implicit operator LinkLayerListUser(Models.Protobuf.LinkmicCommon.LinkLayerListUser user) => new LinkLayerListUser(user);
    }
}
