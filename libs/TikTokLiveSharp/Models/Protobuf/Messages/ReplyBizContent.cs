using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ReplyBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public int LinkType { get; }

        [ProtoMember(2)]
        public int IsTurnOffInvitation { get; }

        [ProtoMember(3)]
        public User ReplyUserInfo { get; }
    }
}
