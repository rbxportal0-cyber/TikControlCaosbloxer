using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PerceptionDialogInfo
    {
        public readonly PerceptionDialogIconType IconType;
        public readonly Text Title;
        public readonly Text SubTitle;
        public readonly Text AdviceActionText;
        public readonly Text DefaultActionText;
        public readonly string ViolationDetailUrl;
        public readonly int Scene;
        public readonly long TargetUserId;
        public readonly long TargetRoomId;
        public readonly long CountDownTime;
        public readonly bool ShowFeedback;
        public readonly IReadOnlyList<PerceptionFeedbackOption> FeedbackOptionsList;
        public readonly long PolicyTip;

        private PerceptionDialogInfo(Models.Protobuf.Objects.PerceptionDialogInfo info)
        {
            IconType = info?.IconType ?? PerceptionDialogIconType.IconTypeNone;
            Title = info?.Title;
            SubTitle = info?.SubTitle;
            AdviceActionText = info?.AdviceActionText;
            DefaultActionText = info?.DefaultActionText;
            ViolationDetailUrl = info?.ViolationDetailUrl ?? string.Empty;
            Scene = info?.Scene ?? -1;
            TargetUserId = info?.TargetUserId ?? -1;
            TargetRoomId = info?.TargetRoomId ?? -1;
            CountDownTime = info?.CountDownTime ?? -1;
            ShowFeedback = info?.ShowFeedback ?? false;
            FeedbackOptionsList = info?.FeedbackOptionsList?.Count > 0 ? info.FeedbackOptionsList.Select(pfo => (PerceptionFeedbackOption)pfo).ToList().AsReadOnly() : new List<PerceptionFeedbackOption>(0).AsReadOnly();
            PolicyTip = info?.PolicyTip ?? -1;
        }

        public static implicit operator PerceptionDialogInfo(Models.Protobuf.Objects.PerceptionDialogInfo info) => new PerceptionDialogInfo(info);
    }
}
