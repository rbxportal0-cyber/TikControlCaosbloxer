using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerLinkedListChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<ListUser> LinkedUsersList { get; } = new List<ListUser>();
    }
}
