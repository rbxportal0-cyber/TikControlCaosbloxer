namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LinkmicAudienceEmoji
    {
        public readonly long EmojiId;
        public readonly bool IsRandom;
        public readonly Picture EmojiImage;
        public readonly Picture EmojiDynamicImage;
        public readonly string EmojiName;
        public readonly long AnimationDurationMs;
        public readonly long EmojiResultDurationMs;

        private LinkmicAudienceEmoji(Models.Protobuf.Objects.LinkmicAudienceEmoji emoji)
        {
            EmojiId = emoji?.EmojiId ?? -1;
            IsRandom = emoji?.IsRandom ?? false;
            EmojiImage = emoji?.EmojiImage;
            EmojiDynamicImage = emoji?.EmojiDynamicImage;
            EmojiName = emoji?.EmojiName ?? string.Empty;
            AnimationDurationMs = emoji?.AnimationDurationMs ?? -1;
            EmojiResultDurationMs = emoji?.EmojiResultDurationMs ?? -1;
        }

        public static implicit operator LinkmicAudienceEmoji(Models.Protobuf.Objects.LinkmicAudienceEmoji emoji) => new LinkmicAudienceEmoji(emoji);
    }
}
