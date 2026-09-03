using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Data;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class GiftMessage : AMessageData
    {
        #region InnerTypes
        public sealed class TextEffect
        {
            public sealed class Detail
            {
                public readonly Text Text;
                public readonly int TextFontSize;
                public readonly Picture Background;
                public readonly int Start;
                public readonly int Duration;
                public readonly int X;
                public readonly int Y;
                public readonly int Width;
                public readonly int Height;
                public readonly int ShadowDx;
                public readonly int ShadowDy;
                public readonly int ShadowRadius;
                public readonly string ShadowColor;
                public readonly string StrokeColor;
                public readonly int StrokeWidth;

                private Detail(Models.Protobuf.Messages.GiftMessage.TextEffect.Detail detail)
                {
                    Text = detail?.Text;
                    TextFontSize = detail?.TextFontSize ?? -1;
                    Background = detail?.Background;
                    Start = detail?.Start ?? -1;
                    Duration = detail?.Duration ?? -1;
                    X = detail?.X ?? -1;
                    Y = detail?.Y ?? -1;
                    Width = detail?.Width ?? -1;
                    Height = detail?.Height ?? -1;
                    ShadowDx = detail?.ShadowDx ?? -1;
                    ShadowDy = detail?.ShadowDy ?? -1;
                    ShadowRadius = detail?.ShadowRadius ?? -1;
                    ShadowColor = detail?.ShadowColor ?? string.Empty;
                    StrokeColor = detail?.StrokeColor ?? string.Empty;
                    StrokeWidth = detail?.StrokeWidth ?? -1;
                }

                public static implicit operator Detail(Models.Protobuf.Messages.GiftMessage.TextEffect.Detail detail) => new Detail(detail);
            }

            public readonly Detail Portrait;
            public readonly Detail Landscape;

            private TextEffect(Models.Protobuf.Messages.GiftMessage.TextEffect effect)
            {
                Portrait = effect?.Portrait;
                Landscape = effect?.Landscape;
            }

            public static implicit operator TextEffect(Models.Protobuf.Messages.GiftMessage.TextEffect effect) => new TextEffect(effect);
        }
        #endregion

        /// <summary>
        /// Gift-Id
        /// </summary>
        public readonly long GiftId;
        /// <summary>
        /// Data for Gift
        /// </summary>
        public readonly Gift Gift;
        /// <summary>
        /// User who sent the Gift
        /// </summary>
        public readonly User User;
        /// <summary>
        /// User who received the Gift
        /// <para>
        /// Usually NULL (which indicates gift was sent to Host)
        /// </para>
        /// </summary>
        public readonly User ToUser;

        /// <summary>
        /// Index of Message in Streak
        /// </summary>
        public readonly long RepeatCount;
        /// <summary>
        /// Number of Gifts sent (this Streak)
        /// </summary>
        public readonly long Amount;
        /// <summary>
        /// Whether this is the final message in the GiftStreak
        /// </summary>
        public readonly bool StreakEnd;

        public readonly long FanTicketCount;
        public readonly long GroupCount;

        public readonly TextEffect Text_Effect;
        public readonly long GroupId;
        public readonly long IncomeTaskGifts;
        public readonly long RoomFanTicketCount;
        public readonly GiftIMPriority Priority;

        public readonly string Log_Id;
        public readonly long SendType;

        public readonly PublicAreaCommon PublicAreaCommon;
        public readonly Text TrayDisplayText;
        public readonly long BannedDisplayEffects;
        public readonly GiftTrayInfo TrayInfo;

        /// <summary>
        /// GiftReceipt
        /// </summary>
        public readonly string MonitorExtra;

        /// <summary>
        /// GiftReceipt
        /// </summary>
        public readonly GiftMonitorInfo MonitorInfo;

        public readonly long ColorId;
        public readonly bool IsFirstSent;
        public readonly Text DisplayTextForHost;
        public readonly Text DisplayTextForAudience;
        public readonly string OrderId;
        public readonly GiftsInBox GiftsInBox;
        public readonly MsgFilter MsgFilter;
        public readonly IReadOnlyList<LynxGiftExtra> LynxExtras;
        public readonly UserIdentity UserIdentity;
        public readonly MatchInfo MatchInfo;
        public readonly LinkmicGiftExpressionStrategy LinkmicGiftExpressionStrategy;
        public readonly FlyingMicResources FlyingMicResources;
        public readonly bool DisableGiftTracking;


        internal GiftMessage(Models.Protobuf.Messages.GiftMessage msg)
            : base(msg?.Header)
        {
            GiftId = msg?.GiftId ?? -1;
            Gift = msg?.Gift;
            User = msg?.User;
            ToUser = msg?.ToUser;
            FanTicketCount = msg?.FanTicketCount ?? -1;
            GroupCount = msg?.GroupCount ?? -1;
            RepeatCount = msg?.RepeatCount ?? -1;
            Amount = msg?.ComboCount ?? -1;
            StreakEnd = msg?.RepeatEnd != 0;
            Text_Effect = msg?.Text_Effect;
            GroupId = msg?.GroupId ?? -1;
            IncomeTaskGifts = msg?.IncomeTaskGifts ?? -1;
            RoomFanTicketCount = msg?.RoomFanTicketCount ?? -1;
            Priority = msg?.Priority;
            Log_Id = msg?.LogId ?? string.Empty;
            SendType = msg?.SendType ?? -1;
            PublicAreaCommon = msg?.PublicAreaCommon;
            TrayDisplayText = msg?.TrayDisplayText;
            BannedDisplayEffects = msg?.BannedDisplayEffects ?? -1;
            TrayInfo = msg?.TrayInfo;
            MonitorExtra = msg?.MonitorExtra ?? string.Empty;
            MonitorInfo = msg?.MonitorInfo;
            ColorId = msg?.ColorId ?? -1;
            IsFirstSent = msg?.IsFirstSent ?? false;
            DisplayTextForHost = msg?.DisplayTextForAnchor;
            DisplayTextForAudience = msg?.DisplayTextForAudience;
            OrderId = msg?.OrderId ?? string.Empty;
            GiftsInBox = msg?.GiftsInBox;
            MsgFilter = msg?.MsgFilter;
            LynxExtras = msg?.LynxExtraList?.Count > 0 ? msg.LynxExtraList.Select(l => (LynxGiftExtra)l).ToList().AsReadOnly() : new List<LynxGiftExtra>(0).AsReadOnly();
            UserIdentity = msg?.UserIdentity;
            MatchInfo = msg?.MatchInfo;
            LinkmicGiftExpressionStrategy = msg?.LinkmicGiftExpressionStrategy ?? LinkmicGiftExpressionStrategy.ControlV1;
            FlyingMicResources = msg?.FlyingMicResources;
            DisableGiftTracking = msg?.DisableGiftTracking ?? false;
        }
    }
}