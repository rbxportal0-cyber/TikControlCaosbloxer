using System.Collections.Generic;

namespace TikTokLiveSharp.Models.HTTP
{
    public class ColorInfo
    {
        public long Color_Id { get; set; }

        public long Color_Effect_Id { get; set; }

        public string Color_Name { get; set; } = string.Empty;

        public List<string> Color_Values { get; set; } = new List<string>();

        public bool Is_Default { get; set; }

        public TikTokImage Color_Image { get; set; }

        public TikTokImage Gift_Image { get; set; }
    }
}
