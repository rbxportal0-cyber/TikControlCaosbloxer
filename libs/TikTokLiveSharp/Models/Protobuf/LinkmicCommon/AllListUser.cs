using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class AllListUser : AProtoBase
    {
        [ProtoMember(2)]
        public List<LinkLayerListUser> LinkedList { get; } = new List<LinkLayerListUser>();

        [ProtoMember(3)]
        public List<LinkLayerListUser> AppliedList { get; } = new List<LinkLayerListUser>();

        [ProtoMember(4)]
        public List<LinkLayerListUser> InvitedList { get; } = new List<LinkLayerListUser>();

        [ProtoMember(5)]
        public List<LinkLayerListUser> ReadyList { get; } = new List<LinkLayerListUser>();
    }
}
