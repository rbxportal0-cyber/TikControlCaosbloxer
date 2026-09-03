using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ToastMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long DisplayDurationMillisecond { get; }

        [ProtoMember(3)]
        public long DelayDisplayDurationMillisecond { get; }
    }
}
