using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Closed Caption for Stream
    /// </summary>
    [ProtoContract]
    public partial class CaptionMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long Timestamp { get; }

        /// <summary>
        /// Duration? EndTime?
        /// </summary>
        [ProtoMember(3)]
        public long Data3 { get; }

        [ProtoMember(4)]
        public CaptionData CaptionData { get; }
    }
}
