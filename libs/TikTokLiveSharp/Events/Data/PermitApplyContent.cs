using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PermitApplyContent
    {
        public readonly Player Permiter;
        public readonly string PermiterLinkMicId;
        public readonly Position ApplierPos;
        public readonly ReplyStatus ReplyStatus;
        public readonly DSLConfig Dsl;
        public readonly Player Applier;
        public readonly Player Operator;
        public readonly string ApplierLinkMicId;

        private PermitApplyContent(Models.Protobuf.Messages.PermitApplyContent content)
        {
            Permiter = content?.Permiter;
            PermiterLinkMicId = content?.PermiterLinkMicId ?? string.Empty;
            ApplierPos = content?.ApplierPos;
            ReplyStatus = content?.ReplyStatus ?? ReplyStatus.Reply_Status_Unknown;
            Dsl = content?.Dsl;
            Applier = content?.Applier;
            Operator = content?.Operator;
            ApplierLinkMicId = content?.ApplierLinkMicId ?? string.Empty;
        }

        public static implicit operator PermitApplyContent(Models.Protobuf.Messages.PermitApplyContent content) => new PermitApplyContent(content);
    }
}
