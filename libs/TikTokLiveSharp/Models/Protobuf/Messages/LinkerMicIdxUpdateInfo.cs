using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerMicIdxUpdateInfo : AProtoBase
    {
        [ProtoMember(1)]
        public MicIdxOperation Op { get; }

        [ProtoMember(2)]
        public long UserId { get; }

        [ProtoMember(3)]
        public long MicIdx { get; }
    }
}
