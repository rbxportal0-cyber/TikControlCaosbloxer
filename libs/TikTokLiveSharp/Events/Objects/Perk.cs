namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Perk
    {
        public readonly string Title;

        private Perk(Models.Protobuf.Objects.Perk perk)
        {
            Title = perk?.Title ?? string.Empty;
        }

        public static implicit operator Perk(Models.Protobuf.Objects.Perk perk) => new Perk(perk);
    }
}
