using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Data;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// User sent one or multiple likes to Stream. Maxes at 15 likes per message
    /// </summary>
    public sealed class Like : AMessageData
    {
        /// <summary>
        /// Number of Likes for this message. Maxes at 15
        /// </summary>
        public readonly long Count;

        /// <summary>
        /// Total Likes for Stream/Host
        /// </summary>
        public readonly long Total;

        public readonly long Color;

        /// <summary>
        /// Sender of Like(s)
        /// </summary>
        public readonly User Sender;

        public readonly string Icon;

        public readonly IReadOnlyList<Picture> Icons;

        public readonly IReadOnlyList<SpecifiedDisplayText> SpecifiedDisplayTexts;

        public readonly IReadOnlyList<LikeEffect> LikeEffects;

        internal Like(Models.Protobuf.Messages.LikeMessage message) : base(message?.Header)
        {
            Count = message?.Count ?? 0;
            Total = message?.Total ?? 0;
            Color = message?.Color ?? 0;
            Sender = message?.User;
            Icon = message?.Icon ?? string.Empty;
            Icons = message?.IconsList?.Count > 0 ? message.IconsList.Select(i => (Picture)i).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
            SpecifiedDisplayTexts = message?.SpecifiedDisplayTextList?.Count > 0 ? message.SpecifiedDisplayTextList.Select(t => (SpecifiedDisplayText)t).ToList().AsReadOnly() : new List<SpecifiedDisplayText>(0).AsReadOnly();
            LikeEffects = message?.LikeEffectList?.Count > 0 ? message.LikeEffectList.Select(e => (LikeEffect)e).ToList().AsReadOnly() : new List<LikeEffect>(0).AsReadOnly();
        }

        internal Like(Models.Protobuf.Messages.SocialMessage message) : base(message?.Header)
        {
            Count = 1;
            Sender = message?.Sender;
            Total = -1;
            Color = -1;
            Icon = string.Empty;
            Icons = new List<Picture>(0).AsReadOnly();
            SpecifiedDisplayTexts = new List<SpecifiedDisplayText>(0).AsReadOnly();
            LikeEffects = new List<LikeEffect>(0).AsReadOnly();
        }
    }
}
