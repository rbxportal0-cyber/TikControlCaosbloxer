using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class P2PGroupChangeContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<RTCExtraInfo> GroupExtInfoList { get; } = new List<RTCExtraInfo>();

        [ProtoMember(2)]
        public GroupChannelAllUser GroupUser { get; }
    }
}
