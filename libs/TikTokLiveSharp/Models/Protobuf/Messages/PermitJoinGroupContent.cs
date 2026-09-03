using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PermitJoinGroupContent : AProtoBase
    {
        [ProtoMember(1)]
        public GroupPlayer Approver { get; }

        [ProtoMember(2)]
        public AgreeStatus AgreeStatus { get; }

        [ProtoMember(3)]
        public JoinType Type { get; }

        [ProtoMember(4)]
        public List<RTCExtraInfo> GroupExtInfoList { get; } = new List<RTCExtraInfo>();

        [ProtoMember(5)]
        public GroupChannelAllUser GroupUser { get; }
    }
}
