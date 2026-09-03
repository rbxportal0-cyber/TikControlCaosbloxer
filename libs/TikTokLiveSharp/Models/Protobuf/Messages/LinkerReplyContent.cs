using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerReplyContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public long FromRoomId { get; }

        [ProtoMember(3)]
        public LinkmicInfo FromUserLinkmicInfo { get; }

        [ProtoMember(4)]
        public long ToUserId { get; }

        [ProtoMember(5)]
        public LinkmicInfo ToUserLinkmicInfo { get; }

        [ProtoMember(6)]
        public long LinkType { get; }

        [ProtoMember(7)]
        public long ReplyStatus { get; }

        [ProtoMember(8)]
        public LinkerSetting LinkerSetting { get; }

        [ProtoMember(9)]
        public User FromUser { get; }

        [ProtoMember(10)]
        public User ToUser { get; }

        [ProtoMember(11)]
        public Dictionary<long, string> RtcExtInfoMap { get; } = new Dictionary<long, string>();

        [ProtoMember(12)]
        public LinkerMicIdxUpdateInfo InviteeMicIdxUpdateInfo { get; }

        [ProtoMember(13)]
        public Dictionary<long, long> ApplierMicIdxInfoMap { get; }

        [ProtoMember(14)]
        public LinkmicMultiLiveEnum AnchorMultiLiveEnum { get; }

        [ProtoMember(15)]
        public LinkmicUserSettingInfo AnchorSettingInfo { get; }

        [ProtoMember(16)]
        public long ActionId { get; }

        [ProtoMember(17)]
        public List<LinkmicUserInfo> LinkedUsersList { get; } = new List<LinkmicUserInfo>();

        [ProtoMember(18)]
        public long SourceType { get; }
    }
}
