using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class BottomMessage : AMessageData
    {
        public readonly string Content;
        public readonly ShowType ShowType;
        public readonly TextType TextType;
        public readonly long Duration;
        public readonly BizType BizType;
        public readonly long ViolationUserId;
        public readonly PunishEventInfo PunishInfo;
        public readonly int Style;
        public readonly string DetailUrl;
        public readonly int FloatStyle;

        internal BottomMessage(Models.Protobuf.Messages.BottomMessage msg)
            : base(msg?.Header)
        {
            Content = msg?.Content ?? string.Empty;
            ShowType = msg?.ShowType ?? ShowType.Hover;
            TextType = msg?.TextType ?? TextType.Display_Text;
            Duration = msg?.Duration ?? -1;
            BizType = msg?.BizType ?? BizType.Default;
            ViolationUserId = msg?.ViolationUserId ?? -1;
            PunishInfo = msg?.PunishInfo;
            Style = msg?.Style ?? -1;
            DetailUrl = msg?.DetailUrl ?? string.Empty;
            FloatStyle = msg?.FloatStyle ?? -1;
        }
    }
}