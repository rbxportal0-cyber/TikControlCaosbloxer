using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class AlertAudio
    {
        public readonly long Id;
        public readonly int AlertType;
        public readonly string TOSUrl;
        public readonly AuditStatus AuditStatus;

        private AlertAudio(Models.Protobuf.Messages.AlertAudio alertAudio)
        {
            Id = alertAudio?.Id ?? -1;
            AlertType = alertAudio?.AlertType ?? -1;
            TOSUrl = alertAudio?.TOSUrl ?? string.Empty;
            AuditStatus = alertAudio?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
        }

        public static implicit operator AlertAudio(Models.Protobuf.Messages.AlertAudio alertAudio) => new AlertAudio(alertAudio);
    }
}
