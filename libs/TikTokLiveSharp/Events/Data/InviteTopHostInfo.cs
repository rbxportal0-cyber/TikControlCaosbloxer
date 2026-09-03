namespace TikTokLiveSharp.Events.Data
{
    public sealed class InviteTopHostInfo
    {
        public readonly string RankType;
        public readonly long TopIndex;

        private InviteTopHostInfo(Models.Protobuf.Messages.InviteTopHostInfo info)
        {
            RankType = info?.RankType ?? string.Empty;
            TopIndex = info?.TopIndex ?? -1;
        }

        public static implicit operator InviteTopHostInfo(Models.Protobuf.Messages.InviteTopHostInfo info) => new InviteTopHostInfo(info);
    }
}
