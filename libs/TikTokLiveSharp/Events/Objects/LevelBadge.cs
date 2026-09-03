namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LevelBadge
    {
        public readonly Picture OriginImg;
        public readonly Picture PreviewImg;

        private LevelBadge(Models.Protobuf.Objects.LevelBadge levelBadge)
        {
            OriginImg = levelBadge?.OriginImg;
            PreviewImg = levelBadge?.PreviewImg;
        }

        public static implicit operator LevelBadge(Models.Protobuf.Objects.LevelBadge levelBadge) => new LevelBadge(levelBadge);
    }
}
