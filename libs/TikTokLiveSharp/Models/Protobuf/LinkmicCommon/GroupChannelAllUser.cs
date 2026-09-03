using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class GroupChannelAllUser : AProtoBase
    {
        [ProtoMember(1)]
        public long GroupChannelId { get; }

        [ProtoMember(2)]
        public List<GroupChannelUser> UserList { get; } = new List<GroupChannelUser>();
    }
}
