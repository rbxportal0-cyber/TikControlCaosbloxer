using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class LokiContent
    {
        public readonly string GiftType;
        public readonly long GiftDuration;
        public readonly bool NeedScreenShot;
        public readonly bool ShouldMultiFrame;
        public readonly string ViewOverlay;
        public readonly BefViewRenderSize BefViewRenderSize;
        public readonly int BefViewRenderFps;
        public readonly int BefViewFitMode;
        public readonly string ModelNames;
        public readonly IReadOnlyList<string> Requirements;

        private LokiContent(Models.Protobuf.Objects.LokiContent lokiContent)
        {
            GiftType = lokiContent?.GiftType ?? string.Empty;
            GiftDuration = lokiContent?.GiftDuration ?? -1;
            NeedScreenShot = lokiContent?.NeedScreenShot ?? false;
            ShouldMultiFrame = lokiContent?.ShouldMultiFrame ?? false;
            ViewOverlay = lokiContent?.ViewOverlay ?? string.Empty;
            BefViewRenderSize = lokiContent?.BefViewRenderSize;
            BefViewRenderFps = lokiContent?.BefViewRenderFps ?? -1;
            BefViewFitMode = lokiContent?.BefViewFitMode ?? -1;
            ModelNames = lokiContent?.ModelNames ?? string.Empty;
            Requirements = lokiContent?.RequirementsList?.Count > 0 ? new List<string>(lokiContent.RequirementsList).AsReadOnly() : new List<string>(0).AsReadOnly();
        }

        public static implicit operator LokiContent(Models.Protobuf.Objects.LokiContent lokiContent) => new LokiContent(lokiContent);
    }
}
