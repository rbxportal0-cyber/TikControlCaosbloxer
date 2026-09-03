using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class FanTicketRoomNoticeContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<UserFanTicket> UserFanTicketList { get; } = new List<UserFanTicket>();

        [ProtoMember(2)]
        public long TotalLinkMicFanTicket { get; }

        [ProtoMember(3)]
        public long MatchId { get; }

        [ProtoMember(4)]
        public long EventTime { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string FanTicketIconUrl { get; } = string.Empty;
    }
}
