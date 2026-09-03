using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    /// <summary>
    /// General TikTok-TextObject
    /// </summary>
    public sealed class Text
    {
        public readonly string Key;

        public readonly string Pattern;

        public readonly TextFormat Format;

        public readonly IReadOnlyList<TextPiece> Pieces;
        
        private Text(Models.Protobuf.Objects.Text text)
        {
            Key = text?.Key ?? string.Empty;
            Pattern = text?.DefaultPattern ?? string.Empty;
            Format = text?.DefaultFormat;
            Pieces = text?.PiecesList?.Count > 0 ? text.PiecesList.Select(t => (TextPiece)t).ToList().AsReadOnly() : new List<TextPiece>(0).AsReadOnly();
        }

        public static implicit operator Text(Models.Protobuf.Objects.Text text) => new Text(text);
    }
}