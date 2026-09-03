using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CohostListChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<CohostListUser> UsersList { get; } = new List<CohostListUser>();
    }
}
