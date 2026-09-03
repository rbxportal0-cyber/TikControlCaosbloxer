using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class JoinGroupBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public int FromRoomAgeRestricted { get; }

        [ProtoMember(2)]
        public Tag FromTag { get; }

        [ProtoMember(3)]
        public PerceptionDialogInfo Dialog { get; }

        [ProtoMember(4)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(101)]
        public JoinGroupMessageExtra JoinGroupMsgExtra { get; }
    }
}
