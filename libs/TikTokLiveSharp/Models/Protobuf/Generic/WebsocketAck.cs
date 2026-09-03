using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    /// <summary>
    /// Acknowledgement-Message for Websocket-Connection
    /// </summary>
    [ProtoContract]
    public partial class WebsocketAck : AProtoBase
    {
        [ProtoMember(2)]
        public ulong Id { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Type { get; } = string.Empty;

        public WebsocketAck(ulong id, string type = "ack")
        {
            Id = id;
            Type = type;
        }
    }
}
