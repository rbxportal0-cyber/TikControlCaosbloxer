using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BadgeText
    {
        public readonly string Key;
        public readonly string DefaultPattern;
        public readonly IReadOnlyList<string> Pieces;

        private BadgeText(Models.Protobuf.Objects.BadgeText badgeText)
        {
            Key = badgeText?.Key ?? string.Empty;
            DefaultPattern = badgeText?.DefaultPattern ?? string.Empty;
            Pieces = badgeText?.PiecesList?.Count > 0 ? new List<string>(badgeText.PiecesList).AsReadOnly() : new List<string>(0).AsReadOnly();
        }

        public static implicit operator BadgeText(Models.Protobuf.Objects.BadgeText badgeText) => new BadgeText(badgeText);
    }
}
