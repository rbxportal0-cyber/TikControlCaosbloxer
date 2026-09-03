using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Data;

namespace TikTokLiveSharp.Events
{
    public sealed class AlertBoxAuditResult : AMessageData
    {
        public readonly long UserId;
        public readonly IReadOnlyList<AlertImage> ImageList;
        public readonly IReadOnlyList<AlertText> TextList;
        public readonly string Scene;
        public readonly IReadOnlyList<AlertAudio> AudioList;

        internal AlertBoxAuditResult(Models.Protobuf.Messages.AlertBoxAuditResultMessage msg)
            : base(msg?.Header)
        {
            UserId = msg?.UserId ?? -1;
            ImageList = msg?.ImageList?.Count > 0 ? msg.ImageList.Select(i => (AlertImage)i).ToList().AsReadOnly() : new List<AlertImage>(0).AsReadOnly();
            TextList = msg?.TextList?.Count > 0 ? msg.TextList.Select(t => (AlertText)t).ToList().AsReadOnly() : new List<AlertText>(0).AsReadOnly();
            Scene = msg?.Scene ?? string.Empty;
            AudioList = msg?.AudioList?.Count > 0 ? msg.AudioList.Select(a => (AlertAudio)a).ToList().AsReadOnly() : new List<AlertAudio>(0).AsReadOnly();
        }
    }
}