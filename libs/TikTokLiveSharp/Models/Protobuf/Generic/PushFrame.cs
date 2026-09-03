using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    /// <summary>
    /// Websocket-Message as sent by TikTok-Server (outer structure)
    /// </summary>
    [ProtoContract]
    public partial class PushFrame : AProtoBase
    {
        [ProtoMember(1)]
        public ulong SeqId { get; set; }

        [ProtoMember(2)]
        public ulong LogId { get; set; }

        [ProtoMember(3)]
        public ulong Service { get; set; }

        [ProtoMember(4)]
        public ulong Method { get; set; }
        
        [ProtoMember(5)]
        public List<PushHeader> HeadersList { get; set; }
        
        [ProtoMember(6)]
        [DefaultValue("")]
        public string PayloadEncoding { get; set; } = string.Empty;

        /// <summary>
        /// "hb" for heartbeat, "msg" for messages
        /// </summary>
        [ProtoMember(7)]
        [DefaultValue("")]
        public string PayloadType { get; set; } = string.Empty;

        /// <summary>
        /// WebcastResponse as Binary
        /// </summary>
        [ProtoMember(8)]
        public byte[] Payload { get; set; }
    }
}
