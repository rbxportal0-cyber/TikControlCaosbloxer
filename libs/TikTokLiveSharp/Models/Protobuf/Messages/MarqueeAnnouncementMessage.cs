using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class MarqueeAnnouncementMessage : AProtoBase
    {
        [ProtoContract]
        public partial class MessageEntity : AProtoBase
        {
            [ProtoMember(1)]
            public NotifyMessage Notify { get; }
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string MessageScene { get; } = string.Empty;

        [ProtoMember(3)]
        public List<MessageEntity> MessageEntityList { get; } = new List<MessageEntity>();
    }
}
