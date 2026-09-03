using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class VoteUser : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string NickName { get; } = string.Empty;

        [ProtoMember(3)]
        public Image AvatarThumb { get; }
    }
}
