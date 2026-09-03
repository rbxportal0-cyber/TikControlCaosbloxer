using System.Collections.Generic;
using System.Collections.ObjectModel;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Message related to Viewers
    /// <para>
    /// Includes Join- & Subscribe-Messages, among others
    /// </para>
    /// </summary>
    public sealed class MemberMessage : AMessageData
    {
        #region InnerTypes
        public sealed class EffectConfig
        {
            public readonly long Type;
            public readonly Picture Icon;
            public readonly long AvatarPos;
            public readonly Text Text;
            public readonly Picture TextIcon;
            public readonly int StayTime;
            public readonly long AnimAssetId;
            public readonly Picture Badge;
            public readonly IReadOnlyList<long> FlexSettings;

            private EffectConfig(Models.Protobuf.Messages.MemberMessage.EffectConfig cfg)
            {
                Type = cfg?.Type ?? -1;
                Icon = cfg?.Icon;
                AvatarPos = cfg?.AvatarPos ?? -1;
                Text = cfg?.Text;
                TextIcon = cfg?.TextIcon;
                StayTime = cfg?.StayTime ?? -1;
                AnimAssetId = cfg?.AnimAssetId ?? -1;
                Badge = cfg?.Badge;
                FlexSettings = cfg?.FlexSettings?.Count > 0 ? new List<long>(cfg.FlexSettings).AsReadOnly() : new List<long>(0).AsReadOnly();
            }

            public static implicit operator EffectConfig(Models.Protobuf.Messages.MemberMessage.EffectConfig cfg) => new EffectConfig(cfg);
        }
        #endregion

        public User User;

        /// <summary>
        /// Available in Join-Message
        /// </summary>
        public long ViewerCount;

        /// <summary>
        /// Usually Host
        /// </summary>
        public User Operator;
        public bool IsSetToAdmin;
        public bool IsTopUser;
        public long RankScore;
        public long TopUserNo;
        public long EnterType;
        public long Action;
        public string ActionDescription;
        public long UserId;
        public EffectConfig Effect_Config;
        public string PopStr;
        public EffectConfig EnterEffectConfig;
        public Picture BackgroundImage;
        public Picture BackgroundImageV2;

        /// <summary>
        /// Identical to details in Header
        /// </summary>
        public Text HostDisplayText;
        public string ClientEnterSource;
        public string ClientEnterType;
        public string ClientLiveReason;
        public long ActionDuration;
        public string UserShareType;
        public DisplayStyle DisplayStyle;
        public IReadOnlyDictionary<int, int> AdminPermissions;
        public int KickSource;
        public long AllowPreviewTime;

        internal MemberMessage(Models.Protobuf.Messages.MemberMessage msg)
            : base(msg?.Header)
        {
            User = msg?.User;
            ViewerCount = msg?.MemberCount ?? -1;
            Operator = msg?.Operator;
            IsSetToAdmin = msg?.IsSetToAdmin ?? false;
            IsTopUser = msg?.IsTopUser ?? false;
            RankScore = msg?.RankScore ?? -1;
            TopUserNo = msg?.TopUserNo ?? -1;
            EnterType = msg?.EnterType ?? -1;
            Action = msg?.Action ?? 0;
            ActionDescription = msg?.ActionDescription ?? string.Empty;
            UserId = msg?.UserId ?? -1;
            Effect_Config = msg?.Effect_Config;
            PopStr = msg?.PopStr ?? string.Empty;
            EnterEffectConfig = msg?.EnterEffectConfig;
            BackgroundImage = msg?.BackgroundImage;
            BackgroundImageV2 = msg?.BackgroundImageV2;
            HostDisplayText = msg?.AnchorDisplayText;
            ClientEnterSource = msg?.ClientEnterSource ?? string.Empty;
            ClientEnterType = msg?.ClientEnterType ?? string.Empty;
            ClientLiveReason = msg?.ClientLiveReason ?? string.Empty;
            ActionDuration = msg?.ActionDuration ?? -1;
            UserShareType = msg?.UserShareType ?? string.Empty;
            DisplayStyle = msg?.DisplayStyle ?? DisplayStyle.DisplayStyleNormal;
            AdminPermissions = msg?.AdminPermissionsMap?.Count > 0 ? new ReadOnlyDictionary<int, int>(msg.AdminPermissionsMap) : new ReadOnlyDictionary<int, int>(new Dictionary<int, int>(0));
            KickSource = msg?.KickSource ?? -1;
            AllowPreviewTime = msg?.AllowPreviewTime ?? -1;
        }
    }
}