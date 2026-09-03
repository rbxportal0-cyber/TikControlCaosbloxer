using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class SubNotify : AMessageData
    {
        public readonly User Sender;
        public readonly ExhibitionType ExhibitionType;
        public readonly long SubMonth;
        public readonly SubscribeType SubscribeType;
        public readonly OldSubscribeStatus OldSubscribeStatus;
        public readonly MessageType MessageType;
        public readonly SubscribingStatus SubscribingStatus;
        public readonly bool IsSend;
        public readonly bool IsCustom;

        internal SubNotify(Models.Protobuf.Messages.SubNotifyMessage msg)
            : base(msg?.Header)
        {
            Sender = msg?.Sender;
            ExhibitionType = msg?.ExhibitionType ?? ExhibitionType.ExhibitionType_Default;
            SubMonth = msg?.SubMonth ?? -1;
            SubscribeType = msg?.SubscribeType ?? SubscribeType.SubscribeType_Once;
            OldSubscribeStatus = msg?.OldSubscribeStatus ?? OldSubscribeStatus.OldSubscribeStatus_First;
            MessageType = msg?.MessageType ?? MessageType.MessageType_SubSuccess;
            SubscribingStatus = msg?.SubscribingStatus ?? SubscribingStatus.SubscribingStatus_Unknown;
            IsSend = msg?.IsSend ?? false;
            IsCustom = msg?.IsCustom ?? false;
        }
    }
}