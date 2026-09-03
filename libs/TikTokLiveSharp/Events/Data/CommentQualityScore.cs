namespace TikTokLiveSharp.Events.Data
{
    public sealed class CommentQualityScore
    {
        public readonly string Version;
        public readonly long Score;

        private CommentQualityScore(Models.Protobuf.Messages.CommentQualityScore score)
        {
            Version = score?.Version ?? string.Empty;
            Score = score?.Score ?? -1;
        }

        public static implicit operator CommentQualityScore(Models.Protobuf.Messages.CommentQualityScore score) => new CommentQualityScore(score);
    }
}
