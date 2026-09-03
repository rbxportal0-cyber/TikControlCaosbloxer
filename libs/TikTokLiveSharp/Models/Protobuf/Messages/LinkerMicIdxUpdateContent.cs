using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerMicIdxUpdateContent : AProtoBase
    {
        [ProtoMember(1)]
        public LinkerMicIdxUpdateInfo MicIdxUpdateInfo { get; }
    }
}
