using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerListChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<ListUser> LinkedUsersList { get; } = new List<ListUser>();

        [ProtoMember(2)]
        public List<ListUser> AppliedUsersList { get; } = new List<ListUser>();

        [ProtoMember(3)]
        public List<ListUser> ConnectingUsersList { get; } = new List<ListUser>();
    }
}
