namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubIntroVideo
    {
        public readonly string ItemId;
        public readonly Picture Cover;
        public readonly string PlayUrl;
        public readonly long Duration;
        public readonly User Creator;
        public readonly string Description;

        private SubIntroVideo(Models.Protobuf.Objects.SubIntroVideo subIntroVideo)
        {
            ItemId = subIntroVideo?.ItemId ?? string.Empty;
            Cover = subIntroVideo?.Cover;
            PlayUrl = subIntroVideo?.PlayUrl ?? string.Empty;
            Duration = subIntroVideo?.Duration ?? -1;
            Creator = subIntroVideo?.Creator;
            Description = subIntroVideo?.Description ?? string.Empty;
        }

        public static implicit operator SubIntroVideo(Models.Protobuf.Objects.SubIntroVideo subIntroVideo) => new SubIntroVideo(subIntroVideo);
    }
}
