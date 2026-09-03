using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Gift
    {
        #region InnerTypes
        public sealed class GiftPanelBanner
        {
            public readonly Text DisplayText;
            public readonly Picture LeftIcon;
            public readonly string SchemaUrl;
            public readonly IReadOnlyList<string> BgColorValues;
            public readonly string BannerLynxUrl;

            private GiftPanelBanner(Models.Protobuf.Objects.GiftStruct.GiftPanelBanner banner)
            {
                DisplayText = banner?.DisplayText;
                LeftIcon = banner?.LeftIcon;
                SchemaUrl = banner?.SchemaUrl ?? string.Empty;
                BgColorValues = banner?.BgColorValuesList?.Count > 0 ? new List<string>(banner.BgColorValuesList).AsReadOnly() : new List<string>(0).AsReadOnly();
                BannerLynxUrl = banner?.BannerLynxUrl ?? string.Empty;
            }

            public static implicit operator GiftPanelBanner(Models.Protobuf.Objects.GiftStruct.GiftPanelBanner banner) => new GiftPanelBanner(banner);
        }

        public sealed class RandomGiftPanelBanner
        {
            public readonly Picture BgImage;
            public readonly Picture ShadingImage;
            public readonly long TargetNum;
            public readonly long CollectNum;
            public readonly string DisplayText;
            public readonly Picture LeftIcon;
            public readonly string SchemaUrl;
            public readonly IReadOnlyList<string> BgColorValues;
            public readonly long Round;

            private RandomGiftPanelBanner(Models.Protobuf.Objects.GiftStruct.RandomGiftPanelBanner banner)
            {
                BgImage = banner?.BgImage;
                ShadingImage = banner?.ShadingImage;
                TargetNum = banner?.TargetNum ?? -1;
                CollectNum = banner?.CollectNum ?? -1;
                DisplayText = banner?.DisplayText ?? string.Empty;
                LeftIcon = banner?.LeftIcon;
                SchemaUrl = banner?.SchemaUrl ?? string.Empty;
                BgColorValues = banner?.BgColorValuesList?.Count > 0 ? new List<string>(banner.BgColorValuesList).AsReadOnly() : new List<string>(0).AsReadOnly();
                Round = banner?.Round ?? -1;
            }

            public static implicit operator RandomGiftPanelBanner(Models.Protobuf.Objects.GiftStruct.RandomGiftPanelBanner banner) => new RandomGiftPanelBanner(banner);
        }

        public sealed class RandomGiftBubble
        {
            public readonly string DisplayText;
            public readonly Picture IconDynamicEffect;

            private RandomGiftBubble(Models.Protobuf.Objects.GiftStruct.RandomGiftBubble bubble)
            {
                DisplayText = bubble?.DisplayText ?? string.Empty;
                IconDynamicEffect = bubble?.IconDynamicEffect;
            }

            public static implicit operator RandomGiftBubble(Models.Protobuf.Objects.GiftStruct.RandomGiftBubble bubble) => new RandomGiftBubble(bubble);
        }

        public sealed class GiftRandomEffectInfo
        {
            public readonly RandomGiftPanelBanner RandomGiftPanelBanner;
            public readonly IReadOnlyList<long> EffectIdsList;
            public readonly string HostKey;
            public readonly string AudienceKey;
            public readonly RandomGiftBubble RandomGiftBubble;

            private GiftRandomEffectInfo(Models.Protobuf.Objects.GiftStruct.GiftRandomEffectInfo info)
            {
                RandomGiftPanelBanner = info?.RandomGiftPanelBanner;
                EffectIdsList = info?.EffectIdsList?.Count > 0 ? new List<long>(info.EffectIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
                HostKey = info?.HostKey ?? string.Empty;
                AudienceKey = info?.AudienceKey ?? string.Empty;
                RandomGiftBubble = info?.RandomGiftBubble;
            }

            public static implicit operator GiftRandomEffectInfo(Models.Protobuf.Objects.GiftStruct.GiftRandomEffectInfo info) => new GiftRandomEffectInfo(info);
        }
        #endregion

        public readonly Picture Image;
        public readonly string Description;
        public readonly long Duration;
        public readonly long Id;
        public readonly bool ForLinkMic;
        public readonly bool Combo;
        public readonly int Type;
        public readonly int DiamondCost;
        public readonly bool IsDisplayedOnPanel;
        public readonly long PrimaryEffectId;
        public readonly Picture GiftLabelIcon;
        public readonly string Name;
        public readonly Picture Icon;
        public readonly string GoldEffect;
        public readonly Picture PreviewImage;
        public readonly GiftPanelBanner GiftPanel_Banner;
        public readonly bool IsBroadcastGift;
        public readonly bool IsEffectBefView;
        public readonly bool IsRandomGift;
        public readonly bool IsBoxGift;
        public readonly bool CanPutInGiftBox;
        public readonly GiftBoxInfo GiftBoxInfo;
        public readonly IReadOnlyDictionary<string, string> TrackerParams;
        public readonly GiftLockInfo LockInfo;
        public readonly IReadOnlyList<GiftColorInfo> ColorInfos;
        public readonly string GiftRankRecommendInfo;
        public readonly GiftRandomEffectInfo RandomEffectInfo;
        public readonly int GiftSubType;
        public readonly IReadOnlyList<int> GiftVerticalScenarios;
        
        /// <summary>
        /// Can this Gift be sent in a Streak?
        /// <para>
        /// Gifts are only Streakable if their Type is 1
        /// </para>
        /// </summary>
        public bool IsStreakable => Type == 1;

        private Gift(Models.Protobuf.Objects.GiftStruct giftStruct)
        {
            Image = giftStruct?.Image;
            Description = giftStruct?.Describe ?? string.Empty;
            Duration = giftStruct?.Duration ?? -1;
            Id = giftStruct?.Id ?? -1;
            ForLinkMic = giftStruct?.ForLinkMic ?? false;
            Combo = giftStruct?.Combo ?? false;
            Type = giftStruct?.Type ?? 0;
            DiamondCost = giftStruct?.DiamondCount ?? -1;
            IsDisplayedOnPanel = giftStruct?.IsDisplayedOnPanel ?? false;
            PrimaryEffectId = giftStruct?.PrimaryEffectId ?? -1;
            GiftLabelIcon = giftStruct?.GiftLabelIcon;
            Name = giftStruct?.Name ?? string.Empty;
            Icon = giftStruct?.Icon;
            GoldEffect = giftStruct?.GoldEffect ?? string.Empty;
            PreviewImage = giftStruct?.PreviewImage;
            GiftPanel_Banner = giftStruct?.GiftPanel_Banner;
            IsBroadcastGift = giftStruct?.IsBroadcastGift ?? false;
            IsEffectBefView = giftStruct?.IsEffectBefView ?? false;
            IsRandomGift = giftStruct?.IsRandomGift ?? false;
            IsBoxGift = giftStruct?.IsBoxGift ?? false;
            CanPutInGiftBox = giftStruct?.CanPutInGiftBox ?? false;
            GiftBoxInfo = giftStruct?.GiftBoxInfo;
            TrackerParams = giftStruct?.TrackerParamsMap?.Count > 0 ? new ReadOnlyDictionary<string, string>(giftStruct.TrackerParamsMap) : new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(0));
            LockInfo = giftStruct?.LockInfo;
            ColorInfos = giftStruct?.ColorInfosList?.Count > 0 ? giftStruct.ColorInfosList.Select(c => (GiftColorInfo)c).ToList().AsReadOnly() : new List<GiftColorInfo>(0).AsReadOnly();
            GiftRankRecommendInfo = giftStruct?.GiftRankRecommendInfo;
            RandomEffectInfo = giftStruct?.RandomEffectInfo;
            GiftSubType = giftStruct?.GiftSubType ?? 0;
            GiftVerticalScenarios = giftStruct?.GiftVerticalScenariosList?.Count > 0 ? new List<int>(giftStruct.GiftVerticalScenariosList).AsReadOnly() : new List<int>(0).AsReadOnly();
        }

        public static implicit operator Gift(Models.Protobuf.Objects.GiftStruct giftStruct) => new Gift(giftStruct);
    }
}
