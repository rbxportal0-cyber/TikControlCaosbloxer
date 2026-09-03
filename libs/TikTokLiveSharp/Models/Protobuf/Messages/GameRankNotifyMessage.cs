using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class GameRankNotifyMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public MessageType MsgType { get; }

        [ProtoMember(3)]
        public Text NotifyText { get; }
    }
}
