using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CancelJoinGroupContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<GroupPlayer> LeaverList { get; } = new List<GroupPlayer>();

        [ProtoMember(2)]
        public GroupPlayer Operator { get; }

        [ProtoMember(3)]
        public ListChangeType Type { get; }
    }
}
