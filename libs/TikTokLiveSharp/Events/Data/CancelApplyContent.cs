using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class CancelApplyContent
    {
        public readonly Player Applier;
        public readonly string ApplierLinkMicId;

        private CancelApplyContent(Models.Protobuf.Messages.CancelApplyContent content)
        {
            Applier = content?.Applier;
            ApplierLinkMicId = content?.ApplierLinkMicId ?? string.Empty;
        }

        public static implicit operator CancelApplyContent(Models.Protobuf.Messages.CancelApplyContent content) => new CancelApplyContent(content);
    }
}
