using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// IntroMessage from Host
    /// </summary>
    public sealed class LiveIntro : AMessageData
    {
        public readonly long LiveIntroRoomId;

        /// <summary>
        /// Host of Room
        /// </summary>
        public readonly User Host;
        /// <summary>
        /// Message-Content
        /// </summary>
        public readonly string Content;

        /// <summary>
        /// Message-Language
        /// <para>
        /// Not always filled
        /// </para>
        /// </summary>
        public readonly string Language;

        public readonly IReadOnlyList<Badge> Badges;

        public readonly int IntroMode;

        public readonly AuditStatus AuditStatus;

        internal LiveIntro(Models.Protobuf.Messages.LiveIntroMessage msg)
            : base(msg?.Header)
        {
            LiveIntroRoomId = msg?.RoomId ?? -1;
            Host = msg?.Host;
            Content = msg?.Content ?? string.Empty;
            Language = msg?.Language ?? string.Empty;
            Badges = msg?.Badges?.Count > 0 ? msg.Badges.Select(b => (Badge)b).ToList().AsReadOnly() : new List<Badge>(0).AsReadOnly();
            IntroMode = msg?.IntroMode ?? 0;
            AuditStatus = msg?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
        }
    }
}