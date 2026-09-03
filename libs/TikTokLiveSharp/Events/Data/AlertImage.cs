using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class AlertImage
    {
        public readonly long Id;
        public readonly int AlertType;
        public readonly string TOSUrl;
        public readonly AuditStatus AuditStatus;

        private AlertImage(Models.Protobuf.Messages.AlertImage alertImage)
        {
            Id = alertImage?.Id ?? -1;
            AlertType = alertImage?.AlertType ?? -1;
            TOSUrl = alertImage?.TOSUrl ?? string.Empty;
            AuditStatus = alertImage?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
        }

        public static implicit operator AlertImage(Models.Protobuf.Messages.AlertImage alertImage) => new AlertImage(alertImage);
    }
}
