using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class RivalExtraInfo
    {
        #region InnerTypes
        #region Enums
        [System.Serializable]
        public enum TextType
        {
            Unknown = 0,
            CurRoomFanTicket = 1,
            TotalDiamondCount = 2,
            Distance = 3,
            DistanceCity = 4
        }
        
        [System.Serializable]
        public enum AnchorLayer
        {
            Unknown = 0,
            Top = 1,
            Small = 2
        }

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
        #endregion

        #region Classes
        public sealed class LinkerInfo
        {
            public sealed class UserInfo
            {
                public readonly long UserId;
                public readonly string NickName;
                public readonly Picture AvatarThumb;

                private UserInfo(Models.Protobuf.Objects.RivalExtraInfo.LinkerInfo.UserInfo info)
                {
                    UserId = info?.UserId ?? -1;
                    NickName = info?.NickName ?? string.Empty;
                    AvatarThumb = info?.AvatarThumb;
                }

                public static implicit operator UserInfo(Models.Protobuf.Objects.RivalExtraInfo.LinkerInfo.UserInfo info) => new UserInfo(info);
            }

            public readonly IReadOnlyList<UserInfo> LinkedUsers;

            private LinkerInfo(Models.Protobuf.Objects.RivalExtraInfo.LinkerInfo info)
            {
                LinkedUsers = info?.LinkedUsersList?.Count > 0 ? info.LinkedUsersList.Select(u => (UserInfo)u).ToList().AsReadOnly() : new List<UserInfo>(0).AsReadOnly();
            }

            public static implicit operator LinkerInfo(Models.Protobuf.Objects.RivalExtraInfo.LinkerInfo info) => new LinkerInfo(info);
        }

        public sealed class ReserveInfo
        {
            public readonly long ReservationId;
            public readonly ReserveReplyStatus ReplyStatus;
            public readonly string BubbleTip;
            public readonly long ResponseTime;
            public readonly bool IsReservationSender;

            private ReserveInfo(Models.Protobuf.Objects.RivalExtraInfo.ReserveInfo info)
            {
                ReservationId = info?.ReservationId ?? -1;
                ReplyStatus = info?.ReplyStatus != null ? (ReserveReplyStatus)info.ReplyStatus : ReserveReplyStatus.ReserveReplyStatusUnknown;
                BubbleTip = info?.BubbleTip ?? string.Empty;
                ResponseTime = info?.ResponseTime ?? -1;
                IsReservationSender = info?.IsReservationSender ?? false;
            }

            public static implicit operator ReserveInfo(Models.Protobuf.Objects.RivalExtraInfo.ReserveInfo info) => new ReserveInfo(info);
        }
        #endregion
        #endregion

        public readonly string Text;
        public readonly TextType Text_Type;
        public readonly string Label;
        public readonly AnchorLayer Anchor_Layer;
        public readonly LinkerInfo Linker_Info;
        public readonly AnchorLinkmicUserSettings LinkmicUserSettings;
        public readonly BattleUserSettings BattleUserSettings;
        public readonly InviteBlockReason Invite_BlockReason;
        public readonly LinkmicPlayType ShowPlayType;
        public readonly TopHostInfo TopHostInfo;
        public readonly Tag Tag;
        public readonly ReserveInfo Reserve_Info;
        public readonly DetailBlockReason DetailBlockReason;
        public readonly OptPairInfo OptPairInfo;
        public readonly TagV2 TagV2;

        private RivalExtraInfo(Models.Protobuf.Objects.RivalExtraInfo info)
        {
            Text = info?.Text ?? string.Empty;
            Text_Type = info?.Text_Type != null ? (TextType)info.Text_Type : TextType.Unknown;
            Label = info?.Label ?? string.Empty;
            Anchor_Layer = info?.Anchor_Layer != null ? (AnchorLayer)info.Anchor_Layer : AnchorLayer.Unknown;
            Linker_Info = info?.Linker_Info;
            LinkmicUserSettings = info?.LinkmicUserSettings;
            BattleUserSettings = info?.BattleUserSettings;
            Invite_BlockReason = info?.Invite_BlockReason != null ? (InviteBlockReason)info.Invite_BlockReason : InviteBlockReason.None;
            ShowPlayType = info?.ShowPlayType ?? LinkmicPlayType.PlayType_Invite;
            TopHostInfo = info?.TopHostInfo;
            Tag = info?.Tag;
            Reserve_Info = info?.Reserve_Info;
            DetailBlockReason = info?.DetailBlockReason ?? DetailBlockReason.BlockReasonNone;
            OptPairInfo = info?.OptPairInfo;
            TagV2 = info?.TagV2;
        }

        public static implicit operator RivalExtraInfo(Models.Protobuf.Objects.RivalExtraInfo info) => new RivalExtraInfo(info);
    }
}
