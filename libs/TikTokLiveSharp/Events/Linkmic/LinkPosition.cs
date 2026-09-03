namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkPosition
    {
        public readonly int Position;
        public readonly int Opt;

        private LinkPosition(Models.Protobuf.LinkmicCommon.LinkPosition linkPos)
        {
            Position = linkPos?.Position ?? -1;
            Opt = linkPos?.Opt ?? -1;
        }

        public static implicit operator LinkPosition(Models.Protobuf.LinkmicCommon.LinkPosition linkPos) => new LinkPosition(linkPos);
    }
}
