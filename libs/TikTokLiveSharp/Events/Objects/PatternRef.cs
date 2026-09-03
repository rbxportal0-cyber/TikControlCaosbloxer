namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PatternRef
    {
        public readonly string Key;

        public readonly string DefaultPattern;

        private PatternRef(Models.Protobuf.Objects.PatternRef patternRef)
        {
            Key = patternRef?.Key ?? string.Empty;
            DefaultPattern = patternRef?.DefaultPattern ?? string.Empty;
        }

        private PatternRef(Models.Protobuf.Objects.TextPiecePatternRef patternRef)
        {
            Key = patternRef?.Key ?? string.Empty;
            DefaultPattern = patternRef?.DefaultPattern ?? string.Empty;
        }

        public static implicit operator PatternRef(Models.Protobuf.Objects.PatternRef patternRef) => new PatternRef(patternRef);
        public static implicit operator PatternRef(Models.Protobuf.Objects.TextPiecePatternRef patternRef) => new PatternRef(patternRef);
    }
}