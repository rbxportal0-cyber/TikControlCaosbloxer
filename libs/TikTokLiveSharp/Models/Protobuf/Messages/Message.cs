using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Server-Message. Binary will deserialize into specific message
    /// </summary>
    [ProtoContract]
    public partial class Message : AProtoBase
    {
        /// <summary>
        /// Method that created the Payload (Usually 'Webcast'+MessageType)
        /// </summary>
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Method { get; } = string.Empty;

        [ProtoMember(2)]
        public byte[] Payload { get; }

        [ProtoMember(3)]
        public long MsgId { get; }

        [ProtoMember(4)]
        public int MsgType { get; }

        [ProtoMember(5)]
        public long Offset { get; }

        [ProtoMember(6)]
        public bool IsHistory { get; }
    }
}
