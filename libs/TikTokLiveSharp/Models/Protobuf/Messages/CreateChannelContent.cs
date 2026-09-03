using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CreateChannelContent : AProtoBase
    {
        [ProtoMember(1)]
        public Player Owner { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string OwnerLinkMicId { get; } = string.Empty;
    }
}
