namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkmicUserInfo
    {
        public readonly long UserId;
        public readonly string LinkmicIdStr;
        public readonly long RoomId;
        public readonly long LinkedTime;

        private LinkmicUserInfo(Models.Protobuf.Messages.LinkmicUserInfo info)
        {
            UserId = info?.UserId ?? -1;
            LinkmicIdStr = info?.LinkmicIdStr ?? string.Empty;
            RoomId = info?.RoomId ?? -1;
            LinkedTime = info?.LinkedTime ?? -1;
        }

        public static implicit operator LinkmicUserInfo(Models.Protobuf.Messages.LinkmicUserInfo info) => new LinkmicUserInfo(info);
    }
}
