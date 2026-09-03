using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class Notice : AMessageData
    {
        public readonly string Content;
        public readonly long NoticeType;
        public readonly string Style;
        public readonly Text Title;
        public readonly Text ViolationReason;
        public readonly Text DisplayText;
        public readonly Text TipsTitle;
        public readonly string TipsUrl;
        public readonly Text NoticeTitle;
        public readonly Text NoticeContent;
        public readonly string Scene;

        internal Notice(Models.Protobuf.Messages.NoticeMessage msg)
            : base(msg?.Header)
        {
            Content = msg?.Content ?? string.Empty;
            NoticeType = msg?.NoticeType ?? -1;
            Style = msg?.Style ?? string.Empty;
            Title = msg?.Title;
            ViolationReason = msg?.ViolationReason;
            DisplayText = msg?.DisplayText;
            TipsTitle = msg?.TipsTitle;
            TipsUrl = msg?.TipsUrl ?? string.Empty;
            NoticeTitle = msg?.NoticeTitle;
            NoticeContent = msg?.NoticeContent;
            Scene = msg?.Scene ?? string.Empty;
        }
    }
}