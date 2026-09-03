using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events
{
    public sealed class MarqueeAnnouncement : AMessageData
    {
        public readonly string Scene;
        public readonly IReadOnlyList<Notify> NotifyList;

        internal MarqueeAnnouncement(Models.Protobuf.Messages.MarqueeAnnouncementMessage msg)
            : base(msg?.Header)
        {
            Scene = msg?.MessageScene ?? string.Empty;
            NotifyList = msg?.MessageEntityList?.Count > 0 ? msg.MessageEntityList.Select(e => new Notify(e.Notify)).ToList().AsReadOnly() : new List<Notify>(0).AsReadOnly();
        }
    }
}