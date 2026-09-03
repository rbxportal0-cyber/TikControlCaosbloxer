using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class GameRankNotify : AMessageData
    {
        public readonly MessageType MsgType;
        public readonly Text NotifyText;

        internal GameRankNotify(Models.Protobuf.Messages.GameRankNotifyMessage msg)
            : base(msg?.Header)
        {
            MsgType = msg?.MsgType ?? MessageType.MessageType_SubSuccess;
            NotifyText = msg?.NotifyText;
        }
    }
}