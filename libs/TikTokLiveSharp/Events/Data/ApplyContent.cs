using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ApplyContent
    {
        public readonly Player Applier;
        public readonly string ApplierLinkMicId;

        private ApplyContent(Models.Protobuf.Messages.ApplyContent content)
        {
            Applier = content?.Applier;
            ApplierLinkMicId = content?.ApplierLinkMicId ?? string.Empty;
        }

        public static implicit operator ApplyContent(Models.Protobuf.Messages.ApplyContent content) => new ApplyContent(content);
    }
}
