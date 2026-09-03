using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Message related to Chat-moderation?
    /// </summary>
    [ProtoContract]
    public partial class ImDeleteMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public List<long> DeleteMsgIdsList { get; } = new List<long>();

        [ProtoMember(3)]
        public List<long> DeleteUserIdsList { get; } = new List<long>();
    }
}
