using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SpeakerMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }
    }
}
