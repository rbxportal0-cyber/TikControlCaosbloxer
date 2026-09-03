using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GameTag
    {
        [System.Serializable]
        public enum GameTagType
        {
            Unknown = 0,
            PCGame = 1,
            MobileGame = 2,
            ConsoleGame = 3
        }
        
        public sealed class GameTagCategory
        {
            public readonly GameTagType GameType;
            public readonly string Title;

            private GameTagCategory(Models.Protobuf.Objects.GameTag.GameTagCategory category)
            {
                GameType = category?.GameType != null ? (GameTagType)category.GameType : GameTagType.Unknown;
                Title = category?.Title ?? string.Empty;
            }

            public static implicit operator GameTagCategory(Models.Protobuf.Objects.GameTag.GameTagCategory category) => new GameTagCategory(category);
        }

        public readonly long Id;
        public readonly string ShowName;
        public readonly string ShortName;
        public readonly string FullName;
        public readonly IReadOnlyList<long> HashtagIds;
        public readonly IReadOnlyList<Hashtag> Hashtags;
        public readonly IReadOnlyList<GameTagCategory> GameCategories;
        public readonly long Landscape;
        public readonly string PackageName;
        public readonly string BundleId;

        private GameTag(Models.Protobuf.Objects.GameTag tag)
        {
            Id = tag?.Id ?? -1;
            ShowName = tag?.ShowName ?? string.Empty;
            ShortName = tag?.ShortName ?? string.Empty;
            FullName = tag?.FullName ?? string.Empty;
            HashtagIds = tag?.HashtagIdList?.Count > 0 ? new List<long>(tag.HashtagIdList).AsReadOnly() : new List<long>(0).AsReadOnly();
            Hashtags = tag?.HashtagList?.Count > 0 ? tag.HashtagList.Select(t => (Hashtag)t).ToList().AsReadOnly() : new List<Hashtag>(0).AsReadOnly();
            GameCategories = tag?.GameCategoryList?.Count > 0 ? tag.GameCategoryList.Select(t => (GameTagCategory)t).ToList().AsReadOnly() : new List<GameTagCategory>(0).AsReadOnly();
            Landscape = tag?.Landscape ?? -1;
            PackageName = tag?.PackageName ?? string.Empty;
            BundleId = tag?.BundleId ?? string.Empty;
        }

        public static implicit operator GameTag(Models.Protobuf.Objects.GameTag tag) => new GameTag(tag);
    }
}
