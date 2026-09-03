namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Tag
    {
        public readonly int Type;
        public readonly string Value;
        public readonly string Text;

        private Tag(Models.Protobuf.Objects.Tag tag)
        {
            Type = tag?.TagType ?? -1;
            Value = tag?.TagValue ?? string.Empty;
            Text = tag?.TagText ?? string.Empty;
        }

        public static implicit operator Tag(Models.Protobuf.Objects.Tag tag) => new Tag(tag);
    }
}
