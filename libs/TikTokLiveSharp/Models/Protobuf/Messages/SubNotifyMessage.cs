using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SubNotifyMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Known as "User" in TikTok's Code
        /// </summary>
        [ProtoMember(2)]
        public User Sender { get; }

        [ProtoMember(3)]
        public ExhibitionType ExhibitionType { get; }

        [ProtoMember(4)]
        public long SubMonth { get; }

        [ProtoMember(5)]
        public SubscribeType SubscribeType { get; }

        [ProtoMember(6)]
        public OldSubscribeStatus OldSubscribeStatus { get; }

        [ProtoMember(7)]
        public MessageType MessageType { get; }

        [ProtoMember(8)]
        public SubscribingStatus SubscribingStatus { get; }

        [ProtoMember(9)]
        public bool IsSend { get; }

        [ProtoMember(10)]
        public bool IsCustom { get; }
    }
}
