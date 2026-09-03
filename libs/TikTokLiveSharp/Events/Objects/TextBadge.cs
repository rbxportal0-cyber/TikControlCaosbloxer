using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TextBadge
    {
        public readonly BadgeDisplayType DisplayType;
        public readonly string Key;
        public readonly string DefaultPattern;
        public readonly IReadOnlyList<string> Pieces;

        private TextBadge(Models.Protobuf.Objects.TextBadge badge)
        {
            DisplayType = badge?.DisplayType ?? BadgeDisplayType.BadgeDisplayType_Unknown;
            Key = badge?.Key ?? string.Empty;
            DefaultPattern = badge?.DefaultPattern ?? string.Empty;
            Pieces = badge?.PiecesList?.Count > 0 ? new List<string>(badge.PiecesList).AsReadOnly() : new List<string>(0).AsReadOnly();
        }

        public static implicit operator TextBadge(Models.Protobuf.Objects.TextBadge badge) => new TextBadge(badge);
    }
}
