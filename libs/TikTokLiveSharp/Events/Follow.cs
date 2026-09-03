using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// User Followed the Host
    /// </summary>
    public sealed class Follow : AMessageData
    {
        public readonly User User;
        public readonly long FollowCount;
        
        internal Follow(Models.Protobuf.Messages.SocialMessage msg)
            : base(msg?.Header)
        {
            User = msg?.Sender;
            FollowCount = msg?.FollowCount ?? -1;
        }
    }
}