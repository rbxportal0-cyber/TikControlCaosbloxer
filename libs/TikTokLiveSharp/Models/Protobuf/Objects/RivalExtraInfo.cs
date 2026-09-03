using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class RivalExtraInfo : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        [System.Serializable]
        public enum TextType
        {
            TextTypeUnknown = 0,
            CurRoomFanTicket = 1,
            TotalDiamondCount = 2,
            Distance = 3,
            DistanceCity = 4
        }

        [ProtoContract]
        [System.Serializable]
        public enum AnchorLayer
        {
            AnchorLayerUnknown = 0,
            AnchorLayerTop = 1,
            AnchorLayerSmall = 2
        }

        [ProtoContract]
        [System.Serializable]
        public enum InviteBlockReason
        {
            None = 0,
            IsLinking = 1,
            InvitationDenied = 2,
            PermissionDenied = 3,
            LowClientVersion = 4,
            RoomPaused = 5,
            LinkMicFull = 6,
            MatureThemeNotMatch = 7,
            ReserveFull = 8,
            RegionalBlock = 9
        }

        [ProtoContract]
        public partial class LinkerInfo : AProtoBase
        {
            [ProtoContract]
            public partial class UserInfo : AProtoBase
            {
                [ProtoMember(1)]
                public long UserId { get; }

                [ProtoMember(2)]
                [DefaultValue("")]
                public string NickName { get; } = string.Empty;

                [ProtoMember(3)]
                public Image AvatarThumb { get; }
            }

            [ProtoMember(1)]
            public List<UserInfo> LinkedUsersList { get; } = new List<UserInfo>();
        }


        [ProtoContract]
        public partial class ReserveInfo : AProtoBase
        {
            [ProtoMember(1)]
            public long ReservationId { get; }

            [ProtoMember(2)]
            public ReserveReplyStatus ReplyStatus { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string BubbleTip { get; } = string.Empty;

            [ProtoMember(4)]
            public long ResponseTime { get; }

            [ProtoMember(5)]
            public bool IsReservationSender { get; }
        }
        #endregion

        [ProtoMember(1)]
        [DefaultValue("")]
        public string Text { get; } = string.Empty;

        [ProtoMember(2)]
        public TextType Text_Type { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Label { get; } = string.Empty;

        [ProtoMember(4)]
        public AnchorLayer Anchor_Layer { get; }

        [ProtoMember(5)]
        public LinkerInfo Linker_Info { get; }

        [ProtoMember(6)]
        public AnchorLinkmicUserSettings LinkmicUserSettings { get; }

        [ProtoMember(7)]
        public BattleUserSettings BattleUserSettings { get; }

        [ProtoMember(8)]
        public InviteBlockReason Invite_BlockReason { get; }

        [ProtoMember(9)]
        public LinkmicPlayType ShowPlayType { get; }

        [ProtoMember(10)]
        public TopHostInfo TopHostInfo { get; }

        [ProtoMember(11)]
        public Tag Tag { get; }

        [ProtoMember(12)]
        public ReserveInfo Reserve_Info { get; }

        [ProtoMember(13)]
        public DetailBlockReason DetailBlockReason { get; }

        [ProtoMember(14)]
        public OptPairInfo OptPairInfo { get; }

        [ProtoMember(15)]
        public TagV2 TagV2 { get; }
    }
}
