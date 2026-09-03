using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Response from TikTokServer. Container for Messages
    /// </summary>
    [ProtoContract]
    public partial class Response : AProtoBase
    {
        [ProtoMember(1)]
        public List<Message> MessagesList { get; } = new List<Message>();

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Cursor { get; } = string.Empty;

        [ProtoMember(3)]
        public long FetchInterval { get; }

        [ProtoMember(4)]
        public long Now { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string InternalExt { get; } = string.Empty;

        /// <summary>
        /// (1 = Websocket, 2 = Long-Polling)
        /// </summary>
        [ProtoMember(6)]
        public int FetchType { get; }

        [ProtoMember(7)]
        public Dictionary<string, string> RouteParamsMap { get; } = new Dictionary<string, string>();

        [ProtoMember(8)]
        public long HeartBeatDuration { get; }

        [ProtoMember(9)]
        public bool NeedsAck { get; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string PushServer { get; } = string.Empty;

        [ProtoMember(11)]
        public bool IsFirst { get; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string HistoryCommentCursor { get; } = string.Empty;

        [ProtoMember(13)]
        public bool HistoryNoMore { get; }
    }
}
