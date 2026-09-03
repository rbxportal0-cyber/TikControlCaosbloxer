using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubscriptionInfo
    {
        public readonly SubscribingStatus CurrentStatus;

        private SubscriptionInfo(Models.Protobuf.Objects.SubscriptionInfo subscriptionInfo)
        {
            CurrentStatus = subscriptionInfo?.CurrentStatus ?? SubscribingStatus.SubscribingStatus_Unknown;
        }

        public static implicit operator SubscriptionInfo(Models.Protobuf.Objects.SubscriptionInfo info) => new SubscriptionInfo(info);
    }
}
