namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class Player
    {
        public readonly long RoomId;
        public readonly long UserId;

        private Player(Models.Protobuf.LinkmicCommon.Player player)
        {
            RoomId = player?.RoomId ?? -1;
            UserId = player?.UserId ?? -1;
        }

        public static implicit operator Player(Models.Protobuf.LinkmicCommon.Player player) => new Player(player);
    }
}
