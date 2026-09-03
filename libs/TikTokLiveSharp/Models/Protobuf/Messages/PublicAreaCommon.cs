using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PublicAreaCommon : AProtoBase
    {
        [ProtoMember(1)]
        public Image UserLabel { get; }

        [ProtoMember(2)]
        public long UserConsumeInRoom { get; }
    }
}
