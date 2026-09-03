using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Hashtag
    {
        public readonly long Id;
        public readonly string Title;
        public readonly Picture Image;
        public readonly HashtagNamespace Namespace;

        private Hashtag(Models.Protobuf.Objects.Hashtag tag)
        {
            Id = tag?.Id ?? -1;
            Title = tag?.Title ?? string.Empty;
            Image = tag?.Image;
            Namespace = tag?.Namespace ?? HashtagNamespace.Global;
        }

        public static implicit operator Hashtag(Models.Protobuf.Objects.Hashtag tag) => new Hashtag(tag);
    }
}
