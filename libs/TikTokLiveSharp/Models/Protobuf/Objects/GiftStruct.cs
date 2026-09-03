using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    /// <summary>
    /// Called "GiftStruct" in TikTok's Code
    /// </summary>
    [ProtoContract]
    public partial class GiftStruct : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class GiftPanelBanner : AProtoBase
        {
            [ProtoMember(1)]
            public Text DisplayText { get; }

            [ProtoMember(2)]
            public Image LeftIcon { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string SchemaUrl { get; } = string.Empty;

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated { get; } = string.Empty;

            [ProtoMember(5)]
            public List<string> BgColorValuesList { get; } = new List<string>();

            [ProtoMember(6)]
            [DefaultValue("")]
            public string BannerLynxUrl { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class RandomGiftPanelBanner : AProtoBase
        {
            [ProtoMember(1)]
            public Image BgImage { get; }

            [ProtoMember(2)]
            public Image ShadingImage { get; }

            [ProtoMember(3)]
            public long TargetNum { get; }

            [ProtoMember(4)]
            public long CollectNum { get; }

            [ProtoMember(5)]
            [DefaultValue("")]
            public string DisplayText { get; } = string.Empty;

            [ProtoMember(6)]
            public Image LeftIcon { get; }

            [ProtoMember(7)]
            [DefaultValue("")]
            public string SchemaUrl { get; } = string.Empty;

            [ProtoMember(8)]
            public List<string> BgColorValuesList { get; } = new List<string>();

            [ProtoMember(9)]
            public long Round { get; }
        }

        [ProtoContract]
        public partial class RandomGiftBubble : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string DisplayText { get; } = string.Empty;

            [ProtoMember(2)]
            public Image IconDynamicEffect { get; }
        }

        [ProtoContract]
        public partial class GiftRandomEffectInfo : AProtoBase
        {
            [ProtoMember(1)]
            public RandomGiftPanelBanner RandomGiftPanelBanner { get; }

            [ProtoMember(2)]
            public List<long> EffectIdsList { get; } = new List<long>();

            [ProtoMember(3)]
            [DefaultValue("")]
            public string HostKey { get; } = string.Empty;

            [ProtoMember(4)]
            [DefaultValue("")]
            public string AudienceKey { get; } = string.Empty;

            [ProtoMember(5)]
            public RandomGiftBubble RandomGiftBubble { get; }
        }
        #endregion

        public bool IsStreakable => Type == 1;

        [ProtoMember(1)]
        public Image Image { get; }
        
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Describe { get; } = string.Empty;

        [ProtoMember(4)]
        public long Duration { get; }

        /// <summary>
        /// Gift-Id
        /// </summary>
        [ProtoMember(5)]
        public long Id { get; }

        [ProtoMember(7)]
        public bool ForLinkMic { get; }

        [ProtoMember(10)]
        public bool Combo { get; }

        /// <summary>
        /// TODO: SHOULD BE AN ENUM?
        /// </summary>
        [ProtoMember(11)]
        public int Type { get; }

        /// <summary>
        /// Value of Gift
        /// <para>
        /// Called "DiamondCount" in TikTok's Code
        /// </para>
        /// </summary>
        [ProtoMember(12)]
        public int DiamondCount { get; }

        [ProtoMember(13)]
        public bool IsDisplayedOnPanel { get; }

        [ProtoMember(14)]
        public long PrimaryEffectId { get; }

        /// <summary>
        /// Additional Image
        /// </summary>
        [ProtoMember(15)]
        public Image GiftLabelIcon { get; }

        /// <summary>
        /// Name of Gift
        /// </summary>
        [ProtoMember(16)]
        [DefaultValue("")]
        public string Name { get; } = string.Empty;

        /// <summary>
        /// Same Url as Image, but with different Color
        /// </summary>
        [ProtoMember(21)]
        public Image Icon { get; }

        [ProtoMember(24)]
        [DefaultValue("")]
        public string GoldEffect { get; } = string.Empty;

        [ProtoMember(47)]
        public Image PreviewImage { get; }

        [ProtoMember(48)]
        public GiftPanelBanner GiftPanel_Banner { get; }

        [ProtoMember(49)]
        public bool IsBroadcastGift { get; }

        [ProtoMember(50)]
        public bool IsEffectBefView { get; }

        [ProtoMember(51)]
        public bool IsRandomGift { get; }

        [ProtoMember(52)]
        public bool IsBoxGift { get; }

        [ProtoMember(53)]
        public bool CanPutInGiftBox { get; }

        [ProtoMember(54)]
        public GiftBoxInfo GiftBoxInfo { get; }

        [ProtoMember(100)]
        public Dictionary<string, string> TrackerParamsMap { get; } = new Dictionary<string, string>();

        [ProtoMember(101)]
        public GiftLockInfo LockInfo { get; }

        [ProtoMember(102)]
        public List<GiftColorInfo> ColorInfosList { get; } = new List<GiftColorInfo>();

        [ProtoMember(103)]
        [DefaultValue("")]
        public string GiftRankRecommendInfo { get; } = string.Empty;

        [ProtoMember(104)]
        public GiftRandomEffectInfo RandomEffectInfo { get; }

        [ProtoMember(105)]
        public int GiftSubType { get; }

        [ProtoMember(106)]
        public List<int> GiftVerticalScenariosList { get; } = new List<int>();
    }
}
