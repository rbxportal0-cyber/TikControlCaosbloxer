using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// User shared the Stream
    /// </summary>
    public sealed class Share : AMessageData
    {
        /// <summary>
        /// Can be NULL
        /// </summary>
        public readonly User User;

        /// <summary>
        /// Amount of Shares for this Message
        /// </summary>
        public readonly int Amount;

        public readonly long ShareType;

        public readonly string ShareTarget;
        
        public readonly long DisplayStyle;

        /// <summary>
        /// Total Shares for Stream?
        /// </summary>
        public readonly long Count;
        
        internal Share(Models.Protobuf.Messages.SocialMessage msg, int amount = 1)
            : base(msg?.Header)
        {
            User = msg?.Sender;
            Amount = amount;
            ShareType = msg?.ShareType ?? 0;
            ShareTarget = msg?.ShareTarget ?? string.Empty;
            DisplayStyle = msg?.ShareDisplayStyle ?? 0;
            Count = msg?.ShareCount ?? -1;
        }
    }
}