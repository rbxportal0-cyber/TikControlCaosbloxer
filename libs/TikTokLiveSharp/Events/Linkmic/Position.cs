namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class Position
    {
        public readonly int Type;
        public readonly LinkPosition Link;

        private Position(Models.Protobuf.LinkmicCommon.Position pos)
        {
            Type = pos?.Type ?? -1;
            Link = pos?.Link;
        }

        public static implicit operator Position(Models.Protobuf.LinkmicCommon.Position pos) => new Position(pos);
    }
}
