using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TikTokLiveSharp.Events.Objects
{
    /// <summary>
    /// Links to Image-Files on the TikTok-CDN
    /// </summary>
    public sealed class Picture
    {
        public sealed class Content
        {
            public readonly string Name;
            public readonly string FontColor;
            public readonly long Level;

            internal Content(string name, string fontColor, long level)
            {
                Name = name;
                FontColor = fontColor;
                Level = level;
            }

            private Content(Models.Protobuf.Objects.Image.Content content)
            {
                Name = content?.Name ?? string.Empty;
                FontColor = content?.FontColor ?? string.Empty;
                Level = content?.Level ?? -1;
            }

            public static implicit operator Content(Models.Protobuf.Objects.Image.Content content) => new Content(content);
        }

        /// <summary>
        /// Urls for Picture
        /// <para>
        /// Usually has 3 different urls with different sizes/extensions
        /// </para>
        /// </summary>
        public readonly IReadOnlyList<string> Urls;
        /// <summary>
        /// Uri for Picture
        /// <para>
        /// Short version of Url
        /// </para>
        /// </summary>
        public readonly string Uri;

        public readonly long Height;
        public readonly long Width;
        public readonly string Color;
        public readonly int Type;
        public readonly string OpenWebUrl;
        public readonly Content ImageContent;
        public readonly bool IsAnimated;

        public Picture(IEnumerable<string> urls, string uri = "", 
            long height = 0, long width = 0, string color = "", 
            int type = 0, string openWebUrl = "", bool isAnimated = false,
            string name = "", string fontColor = "", long level = 0)
        {
            Urls = new List<string>(urls);
            Uri = uri;
            Height = height;
            Width = width;
            Color = color;
            Type = type;
            OpenWebUrl = openWebUrl;
            IsAnimated = isAnimated;
            ImageContent = new Content(name, fontColor, level);
        }

        private Picture(Models.Protobuf.Objects.Image profileImage)
        {
            Urls = profileImage?.Urls?.Count > 0 ? new List<string>(profileImage.Urls).AsReadOnly() : new List<string>(0).AsReadOnly();
            Uri = profileImage?.Uri ?? string.Empty;
            Height = profileImage?.Height ?? -1;
            Width = profileImage?.Width ?? -1;
            Color = profileImage?.AvgColor ?? string.Empty;
            Type = profileImage?.ImageType ?? -1;
            OpenWebUrl = profileImage?.OpenWebUrl ?? string.Empty;
            ImageContent = profileImage?.ImageContent;
            IsAnimated = profileImage?.IsAnimated ?? false;
        }

        private Picture(Models.HTTP.TikTokImage image)
        {
            Urls = image?.Url_List?.AsReadOnly() ?? new List<string>(0).AsReadOnly();
            Uri = image?.Uri ?? string.Empty;
            Height = image?.Height != null ? (long)image.Height : -1;
            Width = image?.Width != null ? (long)image.Width : -1;
            Color = image?.Avg_Color ?? string.Empty;
            Type = image?.Image_Type ?? -1;
            OpenWebUrl = image?.Open_Web_Url ?? string.Empty;
            ImageContent = null;
            IsAnimated = image?.Is_Animated ?? false;
        }

        public static implicit operator Picture(Models.Protobuf.Objects.Image image) => new Picture(image);
        public static implicit operator Picture(Models.HTTP.TikTokImage image) => new Picture(image);
    }
}
