using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Gift sent by user
    /// </summary>
    [ProtoContract]
    public partial class GiftMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class TextEffect : AProtoBase
        {
            [ProtoContract]
            public partial class Detail : AProtoBase
            {
                [ProtoMember(1)]
                public Text Text { get; }

                [ProtoMember(2)]
                public int TextFontSize { get; }

                [ProtoMember(3)]
                public Image Background { get; }

                [ProtoMember(4)]
                public int Start { get; }

                [ProtoMember(5)]
                public int Duration { get; }

                [ProtoMember(6)]
                public int X { get; }

                [ProtoMember(7)]
                public int Y { get; }

                [ProtoMember(8)]
                public int Width { get; }

                [ProtoMember(9)]
                public int Height { get; }

                [ProtoMember(10)]
                public int ShadowDx { get; }

                [ProtoMember(11)]
                public int ShadowDy { get; }

                [ProtoMember(12)]
                public int ShadowRadius { get; }

                [ProtoMember(13)]
                [DefaultValue("")]
                public string ShadowColor { get; } = string.Empty;

                [ProtoMember(14)]
                [DefaultValue("")]
                public string StrokeColor { get; } = string.Empty;

                [ProtoMember(15)]
                public int StrokeWidth { get; }
            }

            [ProtoMember(1)]
            public Detail Portrait { get; }

            [ProtoMember(2)]
            public Detail Landscape { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Gift-ID
        /// </summary>
        [ProtoMember(2)]
        public long GiftId { get; }

        [ProtoMember(3)]
        public long FanTicketCount { get; }

        [ProtoMember(4)]
        public long GroupCount { get; }

        /// <summary>
        /// Index of Message in Streak
        /// </summary>
        [ProtoMember(5)]
        public long RepeatCount { get; }

        /// <summary>
        /// Number of Gifts sent in Streak
        /// </summary>
        [ProtoMember(6)]
        public long ComboCount { get; }

        /// <summary>
        /// User who sent the Gift
        /// </summary>
        [ProtoMember(7)]
        public User User { get; }

        /// <summary>
        /// User who received the Gift
        /// </summary>
        [ProtoMember(8)]
        public User ToUser { get; }

        /// <summary>
        /// Whether this is the final message in the GiftStreak
        /// </summary>
        [ProtoMember(9)]
        public int RepeatEnd { get; }

        [ProtoMember(10)]
        public TextEffect Text_Effect { get; }

        [ProtoMember(11)]
        public long GroupId { get; }

        [ProtoMember(12)]
        public long IncomeTaskGifts { get; }

        [ProtoMember(13)]
        public long RoomFanTicketCount { get; }

        [ProtoMember(14)]
        public GiftIMPriority Priority { get; }

        /// <summary>
        /// Details for Gift that was sent
        /// </summary>
        [ProtoMember(15)]
        public GiftStruct Gift { get; }

        /// <summary>
        /// "202301050654360101042172152C002035"
        /// </summary>
        [ProtoMember(16)]
        [DefaultValue("")]
        public string LogId { get; } = string.Empty;

        [ProtoMember(17)]
        public long SendType { get; }

        [ProtoMember(18)]
        public PublicAreaCommon PublicAreaCommon { get; }

        [ProtoMember(19)]
        public Text TrayDisplayText { get; }

        [ProtoMember(20)]
        public long BannedDisplayEffects { get; }

        [ProtoMember(21)]
        public GiftTrayInfo TrayInfo { get; }

        /// <summary>
        /// GiftReceipt
        /// </summary>
        [ProtoMember(22)]
        [DefaultValue("")]
        public string MonitorExtra { get; } = string.Empty;

        /// <summary>
        /// GiftReceipt
        /// </summary>
        [ProtoMember(23)]
        public GiftMonitorInfo MonitorInfo { get; }

        [ProtoMember(24)]
        public long ColorId { get; }

        [ProtoMember(25)]
        public bool IsFirstSent { get; }

        /// <summary>
        /// "Anchor" is Host
        /// </summary>
        [ProtoMember(26)]
        public Text DisplayTextForAnchor { get; }

        [ProtoMember(27)]
        public Text DisplayTextForAudience { get; }

        [ProtoMember(28)]
        [DefaultValue("")]
        public string OrderId { get; } = string.Empty;

        [ProtoMember(29)]
        public GiftsInBox GiftsInBox { get; }

        [ProtoMember(30)]
        public MsgFilter MsgFilter { get; }
        
        [ProtoMember(31)]
        public List<LynxGiftExtra> LynxExtraList { get; } = new List<LynxGiftExtra>();

        [ProtoMember(32)]
        public UserIdentity UserIdentity { get; }
        
        [ProtoMember(33)]
        public MatchInfo MatchInfo { get; }

        [ProtoMember(34)]
        public LinkmicGiftExpressionStrategy LinkmicGiftExpressionStrategy { get; }

        [ProtoMember(35)]
        public FlyingMicResources FlyingMicResources { get; }

        [ProtoMember(36)]
        public bool DisableGiftTracking { get; }
    }
}
