using TikTokLiveSharp.Events.Enums;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class ControlMessage : AMessageData
    {
        public sealed class Extra
        {
            public readonly string BanInfoUrl;
            public readonly long ReasonNo;
            public readonly Text Title;
            public readonly Text ViolationReason;
            public readonly Text Content;
            public readonly Text GotItButton;
            public readonly Text BanDetailButton;
            public readonly string Source;

            private Extra(Models.Protobuf.Messages.ControlMessage.Extra extra)
            {
                BanInfoUrl = extra?.BanInfoUrl ?? string.Empty;
                ReasonNo = extra?.ReasonNo ?? -1;
                Title = extra?.Title;
                ViolationReason = extra?.ViolationReason;
                Content = extra?.Content;
                GotItButton = extra?.GotItButton;
                BanDetailButton = extra?.BanDetailButton;
                Source = extra?.Source ?? string.Empty;
            }

            public static implicit operator Extra(Models.Protobuf.Messages.ControlMessage.Extra extra) => new Extra(extra);
        }

        public readonly ControlAction Action;
        public readonly string Tips;
        public readonly Extra ExtraData;
        public readonly PerceptionDialogInfo PerceptionDialog;
        public readonly Text PerceptionAudienceText;
        public readonly PunishEventInfo PunishInfo;
        public readonly Text FloatText;
        public readonly int FloatStyle;

        internal ControlMessage(Models.Protobuf.Messages.ControlMessage msg)
            : base(msg?.Header)
        {
            long actionIndex = msg?.Action != null ? (long)msg.Action : 0;
            Action = (ControlAction)actionIndex;
            Tips = msg?.Tips ?? string.Empty;
            ExtraData = msg?.ExtraData;
            PerceptionDialog = msg?.PerceptionDialog;
            PerceptionAudienceText = msg?.PerceptionAudienceText;
            PunishInfo = msg?.PunishInfo;
            FloatText = msg?.FloatText;
            FloatStyle = msg?.FloatStyle ?? -1;
        }
    }
}