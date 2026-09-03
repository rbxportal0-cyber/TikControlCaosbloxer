using System.Collections.Generic;

namespace TikTokLiveSharp.Models.HTTP
{
    /// <summary>
    /// Image-Data for <see cref="TikTokGiftData"/>
    /// </summary>
    public class TikTokImage
    {
        public List<string> Url_List { get; set; } = new List<string>();

        public string Uri { get; set; } = string.Empty;

        public uint Height { get; set; }

        public uint Width { get; set; }

        public string Avg_Color { get; set; } = string.Empty;

        public int Image_Type { get; set; }

        public string Open_Web_Url { get; set; } = string.Empty;

        public bool Is_Animated { get; set; }

        public static explicit operator TikTokImage(Protobuf.Objects.Image img) => new TikTokImage
        {
            Url_List = img?.Urls ?? new List<string>(0),
            Uri = img?.Uri ?? string.Empty,
            Height = (uint)(img?.Height ?? 0),
            Width = (uint)(img?.Height ?? 0),
            Avg_Color = img?.AvgColor,
            Image_Type = img?.ImageType ?? -1,
            Open_Web_Url = img?.OpenWebUrl ?? string.Empty,
            Is_Animated = img?.IsAnimated ?? false
        };
    }
}
