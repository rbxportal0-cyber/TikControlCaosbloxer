using System.Collections.Generic;

namespace TikTokLiveSharp.Models.HTTP
{
    /// <summary>
    /// Data for a TikTokGift, as retrieved from TikTok-Page via HTTP
    /// </summary>
    public class TikTokGiftData
    {
        public long Id { get; set; }

        public bool Combo { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Describe { get; set; } = string.Empty;

        public long Diamond_Count { get; set; }

        public long Duration { get; set; }

        public long Type { get; set; }

        public long Gift_Sub_Type { get; set; }

        public TikTokImage Icon { get; set; }

        public TikTokImage Image { get; set; }

        public bool Is_Random_Gift { get; set; }

        public bool For_Linkmic { get; set; }

        public bool Can_Put_In_Gift_Box { get; set; }

        public bool Is_Box_Gift { get; set; }

        public bool Is_Broadcast_Gift { get; set; }

        public bool Is_Displayed_On_Panel { get; set; }
        
        public long Primary_Effect_Id { get; set; }

        public bool Is_Effect_Befview { get; set; }

        public List<int> Gift_Vertical_Scenarios { get; set; } = new List<int>();

        public Dictionary<string, string> Tracker_Params { get; set; } = new Dictionary<string, string>();

        public LockInfo Lock_Info { get; set; }

        public List<ColorInfo> Color_Infos { get; set; } = new List<ColorInfo>();

        public string Gift_Rank_Recommend_Info { get; set; } = string.Empty;

        public string Gold_Effect { get; set; } = string.Empty;
    }
}
