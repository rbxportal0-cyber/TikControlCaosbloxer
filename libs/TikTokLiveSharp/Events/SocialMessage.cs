using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Message related to Viewers
    /// <para>
    /// Includes Follow-, Like-, Share- & Join-Messages, among others
    /// </para>
    /// </summary>
    public sealed class SocialMessage : AMessageData
    {
        public readonly User Sender;
        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        public readonly long ShareType;
        /// <summary>
        /// Share - 3
        /// 
        /// </summary>
        public readonly long Action;
        public readonly string ShareTarget;

        /// <summary>
        /// Exists on Follow-Messages
        /// </summary>
        public readonly long FollowCount;
        public readonly long ShareDisplayStyle;

        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        public readonly long ShareCount;

        internal SocialMessage(Models.Protobuf.Messages.SocialMessage msg)
            : base(msg?.Header)
        {
            Sender = msg?.Sender;
            ShareType = msg?.ShareType ?? 0;
            Action = msg?.Action ?? 0;
            ShareTarget = msg?.ShareTarget ?? string.Empty;
            FollowCount = msg?.FollowCount ?? -1;
            ShareDisplayStyle = msg?.ShareDisplayStyle ?? -1;
            ShareCount = msg?.ShareCount ?? -1;
        }
    }
}