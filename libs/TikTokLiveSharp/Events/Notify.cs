using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class Notify : AMessageData
    {
        #region InnerTypes
        public sealed class Background
        {
            public readonly int Width;
            public readonly int Height;
            public readonly IReadOnlyList<string> Urls;
            public readonly string Uri;

            private Background(Models.Protobuf.Messages.NotifyMessage.Background background)
            {
                Width = background?.Width ?? -1;
                Height = background?.Height ?? -1;
                Urls = background?.UrlList?.Count > 0 ? background.UrlList.AsReadOnly() : new List<string>(0).AsReadOnly();
                Uri = background?.Uri ?? string.Empty;
            }

            public static implicit operator Background(Models.Protobuf.Messages.NotifyMessage.Background background) => new Background(background);
        }
        
        public sealed class Content
        {
            public readonly string ContentStr;
            public readonly bool NeedHighLight;

            private Content(Models.Protobuf.Messages.NotifyMessage.Content content)
            {
                ContentStr = content?.ContentStr ?? string.Empty;
                NeedHighLight = content?.NeedHighLight ?? false;
            }

            public static implicit operator Content(Models.Protobuf.Messages.NotifyMessage.Content content) => new Content(content);
        }
        
        public sealed class ContentList
        {
            public readonly IReadOnlyList<Content> Contents;
            public readonly string HighLightColor;

            private ContentList(Models.Protobuf.Messages.NotifyMessage.ContentList contentList)
            {
                Contents = contentList?.ContentsList?.Count > 0 ? contentList.ContentsList.Select(c => (Content)c).ToList().AsReadOnly() : null;
                HighLightColor = contentList?.HighLightColor ?? string.Empty;
            }

            public static implicit operator ContentList(Models.Protobuf.Messages.NotifyMessage.ContentList contentList) => new ContentList(contentList);
        }
        
        public sealed class Extra
        {
            public readonly long Duration;
            public readonly Background Background;
            public readonly ContentList ContentList;

            private Extra(Models.Protobuf.Messages.NotifyMessage.Extra extra)
            {
                Duration = extra?.Duration ?? -1;
                Background = extra?.Background;
                ContentList = extra?.ContentList;
            }

            public static implicit operator Extra(Models.Protobuf.Messages.NotifyMessage.Extra extra) => new Extra(extra);
        }
        #endregion

        public readonly string Schema;
        public readonly long NotifyType;
        public readonly string ContentStr;
        public readonly User User;
        public readonly Extra ExtraData;
        public readonly long NotifyClass;
        public readonly IReadOnlyList<long> FlexSettingList;
        public readonly string Source;
        public readonly long FromUserId;
        public readonly PrivilegeLogExtra PrivilegeLogExtra;
        public readonly long ToAnchorId;


        internal Notify(Models.Protobuf.Messages.NotifyMessage msg)
            : base(msg?.Header)
        {
            Schema = msg?.Schema ?? string.Empty;
            NotifyType = msg?.NotifyType ?? -1;
            ContentStr = msg?.ContentStr ?? string.Empty;
            User = msg?.User;
            ExtraData = msg?.ExtraData;
            NotifyClass = msg?.NotifyClass ?? -1;
            FlexSettingList = msg?.FlexSettingList?.Count > 0 ? msg.FlexSettingList.AsReadOnly() : new List<long>(0).AsReadOnly();
            Source = msg?.Source ?? string.Empty;
            FromUserId = msg?.FromUserId ?? -1;
            PrivilegeLogExtra = msg?.PrivilegeLogExtra;
            ToAnchorId = msg?.ToAnchorId ?? -1;
        }
    }
}