using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class PartnershipPunish : AMessageData
    {
        public readonly PunishEventInfo PunishInfo;

        internal PartnershipPunish(Models.Protobuf.Messages.PartnershipPunishMessage msg)
            : base(msg?.Header)
        {
            PunishInfo = msg?.PunishInfo;
        }
    }
}