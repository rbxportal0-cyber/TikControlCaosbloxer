using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class AlertText
    {
        public readonly long Id;
        public readonly int AlertType;
        public readonly string Text;
        public readonly AuditStatus AuditStatus;

        private AlertText(Models.Protobuf.Messages.AlertText alertText)
        {
            Id = alertText?.Id ?? -1;
            AlertType = alertText?.AlertType ?? -1;
            Text = alertText?.Text ?? string.Empty;
            AuditStatus = alertText?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
        }

        public static implicit operator AlertText(Models.Protobuf.Messages.AlertText alertText) => new AlertText(alertText);
    }
}
