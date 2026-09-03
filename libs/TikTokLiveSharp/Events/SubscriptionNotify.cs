using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class SubscriptionNotify : AMessageData
    {
        public readonly User User;
        public readonly ExhibitionType ExhibitionType;

        internal SubscriptionNotify(Models.Protobuf.Messages.SubscriptionNotifyMessage msg)
            : base(msg?.Header)
        {
            User = msg?.User;
            ExhibitionType = msg?.ExhibitionType ?? ExhibitionType.ExhibitionType_Default;
        }
    }
}