using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Message sent by Room itself
    /// <para>
    /// This includes TikTok's own "Welcome to TikTokLive"-message
    /// </para>
    /// </summary>
    public sealed class RoomMessage : AMessageData
    {
        /// <summary>
        /// Contents of Message
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Icon for Message
        /// </summary>
        public readonly Picture Icon;
        /// <summary>
        /// Whether message supports viewing in Landscape
        /// </summary>
        public readonly bool SupportsLandscape;
        /// <summary>
        /// Whether this is the Welcome-Message for the Room
        /// <para>
        /// Welcome-Message is the "Welcome to TikTok LIVE! ..."-message
        /// </para>
        /// </summary>
        public readonly bool IsWelcomeMessage;

        public readonly string Scene;
        public readonly long Source;

        internal RoomMessage(Models.Protobuf.Messages.RoomMessage msg)
            : base(msg?.Header)
        {
            Message = msg?.Content ?? string.Empty;
            Icon = msg?.Icon;
            SupportsLandscape = msg?.SupprotLandscape ?? false;
            IsWelcomeMessage = msg?.IsWelcome ?? false;
            Scene = msg?.Scene ?? string.Empty;
            Source = msg?.Source ?? -1;
        }
    }
}