namespace TikTokLiveSharp.Events.Objects
{
    public sealed class MatchInfo
    {
        public readonly long Critical;

        private MatchInfo(Models.Protobuf.Objects.MatchInfo info)
        {
            Critical = info?.Critical ?? -1;
        }

        public static implicit operator MatchInfo(Models.Protobuf.Objects.MatchInfo info) => new MatchInfo(info);
    }
}
