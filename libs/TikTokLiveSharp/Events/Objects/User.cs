using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class User
    {
        #region InnerTypes
        public sealed class FollowInfo
        {
            public readonly long FollowingCount;
            public readonly long FollowerCount;
            public readonly long FollowStatus;
            public readonly long PushStatus;

            private FollowInfo(Models.Protobuf.Objects.User.FollowInfo info)
            {
                FollowingCount = info?.FollowingCount ?? -1;
                FollowerCount = info?.FollowerCount ?? -1;
                FollowStatus = info?.FollowStatus ?? -1;
                PushStatus = info?.PushStatus ?? -1;
            }

            public static implicit operator FollowInfo(Models.Protobuf.Objects.User.FollowInfo info) => new FollowInfo(info);
        }
        
        public sealed class PayGrade
        {
            public sealed class GradeIcon
            {
                public readonly Picture Icon;
                public readonly long IconDiamond;
                public readonly long Level;
                public readonly string LevelString;

                private GradeIcon(Models.Protobuf.Objects.User.PayGrade.GradeIcon icon)
                {
                    Icon = icon?.Icon;
                    IconDiamond = icon?.IconDiamond ?? -1;
                    Level = icon?.Level ?? -1;
                    LevelString = icon?.LevelStr ?? string.Empty;
                }

                public static implicit operator GradeIcon(Models.Protobuf.Objects.User.PayGrade.GradeIcon icon) => new GradeIcon(icon);
            }

            public readonly Picture DiamondIcon;
            public readonly string Name;
            public readonly Picture Icon;
            public readonly string NextName;
            public readonly long Level;
            public readonly Picture NextIcon;
            public readonly string GradeDescription;
            public readonly IReadOnlyList<GradeIcon> GradeIcons;
            public readonly long ScreenChatType;
            public readonly Picture ImIcon;
            public readonly Picture ImIconWithLevel;
            public readonly Picture LiveIcon;
            public readonly Picture NewImIconWithLevel;
            public readonly Picture NewLiveIcon;
            public readonly long UpgradeNeedConsume;
            public readonly string NextPrivileges;
            public readonly Picture Background;
            public readonly Picture BackgroundBack;
            public readonly long Score;
            public readonly string GradeBanner;
            public readonly Picture ProfileDialogBg;
            public readonly Picture ProfileDialogBgBack;

            private PayGrade(Models.Protobuf.Objects.User.PayGrade payGrade)
            {
                DiamondIcon = payGrade?.DiamondIcon;
                Name = payGrade?.Name ?? string.Empty;
                Icon = payGrade?.Icon;
                NextName = payGrade?.NextName ?? string.Empty;
                Level = payGrade?.Level ?? -1;
                NextIcon = payGrade?.NextIcon;
                GradeDescription = payGrade?.GradeDescribe ?? string.Empty;
                GradeIcons = payGrade?.GradeIconList?.Count > 0 ? payGrade.GradeIconList.Select(i => (GradeIcon)i).ToList().AsReadOnly() : new List<GradeIcon>(0).AsReadOnly();
                ScreenChatType = payGrade?.ScreenChatType ?? -1;
                ImIcon = payGrade?.ImIcon;
                ImIconWithLevel = payGrade?.ImIconWithLevel;
                LiveIcon = payGrade?.LiveIcon;
                NewImIconWithLevel = payGrade?.NewImIconWithLevel;
                NewLiveIcon = payGrade?.NewLiveIcon;
                UpgradeNeedConsume = payGrade?.UpgradeNeedConsume ?? -1;
                NextPrivileges = payGrade?.NextPrivileges ?? string.Empty;
                Background = payGrade?.Background;
                BackgroundBack = payGrade?.BackgroundBack;
                Score = payGrade?.Score ?? -1;
                GradeBanner = payGrade?.GradeBanner ?? string.Empty;
                ProfileDialogBg = payGrade?.ProfileDialogBg;
                ProfileDialogBgBack = payGrade?.ProfileDialogBgBack;
            }

            public static implicit operator PayGrade(Models.Protobuf.Objects.User.PayGrade payGrade) => new PayGrade(payGrade);
        }
        
        public sealed class FansClub
        {
            public sealed class FansClubData
            {
                #region InnerTypes
                [System.Serializable]
                public enum BadgeIcon
                {
                    Unknown = 0,
                    Icon = 1,
                    SmallIcon = 2
                }
                
                [System.Serializable]
                public enum UserFansClubStatus
                {
                    NotJoined = 0,
                    Active = 1,
                    Inactive = 2
                }
                
                public sealed class UserBadge
                {
                    public readonly IReadOnlyDictionary<int, Picture> Icons;
                    public readonly string Title;

                    private UserBadge(Models.Protobuf.Objects.User.FansClub.FansClubData.UserBadge badge)
                    {
                        Icons = badge?.IconsMap?.Count > 0 ? badge.IconsMap.ToDictionary(k => k.Key, k => (Picture)k.Value) : new Dictionary<int, Picture>(0);
                        Title = badge?.Title ?? string.Empty;
                    }

                    public static implicit operator UserBadge(Models.Protobuf.Objects.User.FansClub.FansClubData.UserBadge badge) => new UserBadge(badge);
                }
                #endregion

                public readonly string ClubName;
                public readonly int Level;
                public readonly UserFansClubStatus FansClubStatus;
                public readonly UserBadge Badge;
                public readonly IReadOnlyList<long> AvailableGiftIds;
                public readonly long HostId;

                private FansClubData(Models.Protobuf.Objects.User.FansClub.FansClubData data)
                {
                    ClubName = data?.ClubName ?? string.Empty;
                    Level = data?.Level ?? -1;
                    FansClubStatus = data?.FansClubStatus != null ? (UserFansClubStatus)data.FansClubStatus : UserFansClubStatus.NotJoined;
                    Badge = data?.Badge;
                    AvailableGiftIds = data?.AvailableGiftIdsList?.Count > 0 ? new List<long>(data.AvailableGiftIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
                    HostId = data?.AnchorId ?? -1;
                }

                public static implicit operator FansClubData(Models.Protobuf.Objects.User.FansClub.FansClubData data) => new FansClubData(data);
            }
            
            public readonly FansClubData Data;
            public readonly IReadOnlyDictionary<int, FansClubData> PreferData;

            private FansClub(Models.Protobuf.Objects.User.FansClub club)
            {
                Data = club?.Data;
                PreferData = club?.PreferDataMap?.Count > 0 ? new ReadOnlyDictionary<int, FansClubData>(club.PreferDataMap.ToDictionary(k => k.Key, k => (FansClubData)k.Value)) : new ReadOnlyDictionary<int, FansClubData>(new Dictionary<int, FansClubData>(0));
            }

            public static implicit operator FansClub(Models.Protobuf.Objects.User.FansClub club) => new FansClub(club);
        }
        
        public sealed class Border
        {
            public readonly Picture Icon;
            public readonly long Level;
            public readonly string Source;
            public readonly Picture ProfileDecorationRibbon;
            public readonly PrivilegeLogExtra BorderPrivilegeLogExtra;
            public readonly PrivilegeLogExtra ProfilePrivilegeLogExtra;
            public readonly string AvatarBackgroundColor;
            public readonly string AvatarBackgroundBorderColor;

            private Border(Models.Protobuf.Objects.BorderInfo border)
            {
                Icon = border?.Icon;
                Level = border?.Level ?? -1;
                Source = border?.Source ?? string.Empty;
                ProfileDecorationRibbon = border?.ProfileDecorationRibbon;
                BorderPrivilegeLogExtra = border?.BorderPrivilegeLogExtra;
                ProfilePrivilegeLogExtra = border?.ProfilePrivilegeLogExtra;
                AvatarBackgroundColor = border?.AvatarBackgroundColor ?? string.Empty;
                AvatarBackgroundBorderColor = border?.AvatarBackgroundBorderColor ?? string.Empty;
            }

            public static implicit operator Border(Models.Protobuf.Objects.BorderInfo border) => new Border(border);
        }

        public sealed class OwnRoom
        {
            public readonly IReadOnlyList<long> RoomIds;
            public readonly IReadOnlyList<string> RoomIdStrings;

            private OwnRoom(Models.Protobuf.Objects.User.OwnRoom room)
            {
                RoomIds = room?.RoomIdsList?.Count > 0 ? new List<long>(room.RoomIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
                RoomIdStrings = room?.RoomIdsStrList?.Count > 0 ? new List<string>(room.RoomIdsStrList).AsReadOnly() : new List<string>(0).AsReadOnly();
            }

            public static implicit operator OwnRoom(Models.Protobuf.Objects.User.OwnRoom room) => new OwnRoom(room);
        }
        
        public sealed class HostInfo
        {
            public readonly long Level;

            private HostInfo(Models.Protobuf.Objects.AnchorInfo info)
            {
                Level = info?.Level ?? -1;
            }

            public static implicit operator HostInfo(Models.Protobuf.Objects.AnchorInfo info) => new HostInfo(info);
        }
        
        public sealed class HostLevel
        {
            public readonly long Level;
            public readonly long Experience;
            public readonly long LowestExperienceThisLevel;
            public readonly long HighestExperienceThisLevel;
            public readonly long TaskStartExperience;
            public readonly long TaskStartTime;
            public readonly long TaskDecreaseExperience;
            public readonly long TaskTargetExperience;
            public readonly long TaskEndTime;
            public readonly Picture ProfileDialogBg;
            public readonly Picture ProfileDialogBgBack;
            public readonly Picture StageLevel;
            public readonly Picture SmallIcon;

            private HostLevel(Models.Protobuf.Objects.User.AnchorLevel level)
            {
                Level = level?.Level ?? -1;
                Experience = level?.Experience ?? -1;
                LowestExperienceThisLevel = level?.LowestExperienceThisLevel ?? -1;
                HighestExperienceThisLevel = level?.HighestExperienceThisLevel ?? -1;
                TaskStartExperience = level?.TaskStartExperience ?? -1;
                TaskStartTime = level?.TaskStartTime ?? -1;
                TaskDecreaseExperience = level?.TaskDecreaseExperience ?? -1;
                TaskTargetExperience = level?.TaskTargetExperience ?? -1;
                TaskEndTime = level?.TaskEndTime ?? -1;
                ProfileDialogBg = level?.ProfileDialogBg;
                ProfileDialogBgBack = level?.ProfileDialogBgBack;
                StageLevel = level?.StageLevel;
                SmallIcon = level?.SmallIcon;
            }

            public static implicit operator HostLevel(Models.Protobuf.Objects.User.AnchorLevel level) => new HostLevel(level);
        }
        
        public sealed class AuthorStats
        {
            public readonly long VideoTotalCount;
            public readonly long VideoTotalPlayCount;
            public readonly long VideoTotalShareCount;
            public readonly long VideoTotalSeriesCount;
            public readonly long VarietyShowPlayCount;
            public readonly long VideoTotalFavoriteCount;

            private AuthorStats(Models.Protobuf.Objects.User.AuthorStats stats)
            {
                VideoTotalCount = stats?.VideoTotalCount ?? -1;
                VideoTotalPlayCount = stats?.VideoTotalPlayCount ?? -1;
                VideoTotalShareCount = stats?.VideoTotalShareCount ?? -1;
                VideoTotalSeriesCount = stats?.VideoTotalSeriesCount ?? -1;
                VarietyShowPlayCount = stats?.VarietyShowPlayCount ?? -1;
                VideoTotalFavoriteCount = stats?.VideoTotalFavoriteCount ?? -1;
            }

            public static implicit operator AuthorStats(Models.Protobuf.Objects.User.AuthorStats stats) => new AuthorStats(stats);
        }
        
        public sealed class ActivityInfo
        {
            public readonly Picture Badge;
            public readonly Picture StoryTag;

            private ActivityInfo(Models.Protobuf.Objects.User.ActivityInfo info)
            {
                Badge = info?.Badge;
                StoryTag = info?.StoryTag;
            }

            public static implicit operator ActivityInfo(Models.Protobuf.Objects.User.ActivityInfo info) => new ActivityInfo(info);
        }
        
        public sealed class AuthenticationInfo
        {
            public readonly string CustomVerify;
            public readonly string EnterpriseVerifyReason;
            public readonly Picture AuthenticationBadge;

            private AuthenticationInfo(Models.Protobuf.Objects.User.AuthenticationInfo info)
            {
                CustomVerify = info?.CustomVerify ?? string.Empty;
                EnterpriseVerifyReason = info?.EnterpriseVerifyReason ?? string.Empty;
                AuthenticationBadge = info?.AuthenticationBadge;
            }

            public static implicit operator AuthenticationInfo(Models.Protobuf.Objects.User.AuthenticationInfo info) => new AuthenticationInfo(info);
        }
        
        public sealed class ComboBadgeInfo
        {
            public readonly Picture Icon;
            public readonly long ComboCount;

            private ComboBadgeInfo(Models.Protobuf.Objects.User.ComboBadgeInfo info)
            {
                Icon = info?.Icon;
                ComboCount = info?.ComboCount ?? -1;
            }

            public static implicit operator ComboBadgeInfo(Models.Protobuf.Objects.User.ComboBadgeInfo info) => new ComboBadgeInfo(info);
        }
        
        public sealed class SubscribeBadge
        {
            public readonly Picture OriginImg;
            public readonly Picture PreviewImg;

            private SubscribeBadge(Models.Protobuf.Objects.User.SubscribeBadge badge)
            {
                OriginImg = badge?.OriginImg;
                PreviewImg = badge?.PreviewImg;
            }

            public static implicit operator SubscribeBadge(Models.Protobuf.Objects.User.SubscribeBadge badge) => new SubscribeBadge(badge);
        }
        
        public sealed class SubscribeInfo
        {
            public readonly bool Qualification;
            public readonly bool IsSubscribe;
            public readonly SubscribeBadge Badge;
            public readonly bool EnableSubscription;
            public readonly long SubscriberCount;
            public readonly bool IsInGracePeriod;
            public readonly bool IsSubscribedToAnchor;
            public readonly TimerDetail TimerDetail;
            public readonly bool UserGiftSubAuth;
            public readonly bool AnchorGiftSubAuth;

            private SubscribeInfo(Models.Protobuf.Objects.User.SubscribeInfo info)
            {
                Qualification = info?.Qualification ?? false;
                IsSubscribe = info?.IsSubscribe ?? false;
                Badge = info?.Badge;
                EnableSubscription = info?.EnableSubscription ?? false;
                SubscriberCount = info?.SubscriberCount ?? -1;
                IsInGracePeriod = info?.IsInGracePeriod ?? false;
                IsSubscribedToAnchor = info?.IsSubscribedToAnchor ?? false;
                TimerDetail = info?.TimerDetail;
                UserGiftSubAuth = info?.UserGiftSubAuth ?? false;
                AnchorGiftSubAuth = info?.AnchorGiftSubAuth ?? false;
            }

            public static implicit operator SubscribeInfo(Models.Protobuf.Objects.User.SubscribeInfo info) => new SubscribeInfo(info);
        }
        
        public sealed class FansClubInfo
        {
            public readonly bool IsSleeping;
            public readonly long FansLevel;
            public readonly long FansScore;
            public readonly Picture Badge;
            public readonly long FansCount;

            private FansClubInfo(Models.Protobuf.Objects.User.FansClubInfo info)
            {
                IsSleeping = info?.IsSleeping ?? false;
                FansLevel = info?.FansLevel ?? -1;
                FansScore = info?.FansScore ?? -1;
                Badge = info?.Badge;
                FansCount = info?.FansCount ?? -1;
            }

            public static implicit operator FansClubInfo(Models.Protobuf.Objects.User.FansClubInfo info) => new FansClubInfo(info);
        }
        
        public sealed class UserStats
        {
            public readonly long Id;
            public readonly string IdString;
            public readonly long FollowingCount;
            public readonly long FollowerCount;
            public readonly long RecordCount;
            public readonly long TotalDuration;
            public readonly long DailyFanTicketCount;
            public readonly long DailyIncome;
            public readonly long ItemCount;
            public readonly long FavoriteItemCount;
            public readonly long DiamondConsumedCount;
            public readonly long TuwenItemCount;

            private UserStats(Models.Protobuf.Objects.User.UserStats info)
            {
                Id = info?.Id ?? -1;
                IdString = info?.IdStr ?? string.Empty;
                FollowingCount = info?.FollowingCount ?? -1;
                FollowerCount = info?.FollowerCount ?? -1;
                RecordCount = info?.RecordCount ?? -1;
                TotalDuration = info?.TotalDuration ?? -1;
                DailyFanTicketCount = info?.DailyFanTicketCount ?? -1;
                DailyIncome = info?.DailyIncome ?? -1;
                ItemCount = info?.ItemCount ?? -1;
                FavoriteItemCount = info?.FavoriteItemCount ?? -1;
                DiamondConsumedCount = info?.DiamondConsumedCount ?? -1;
                TuwenItemCount = info?.TuwenItemCount ?? -1;
            }

            public static implicit operator UserStats(Models.Protobuf.Objects.User.UserStats info) => new UserStats(info);
        }
        
        public sealed class EcommerceEntrance
        {
            #region InnerTypes
            [System.Serializable]
            public enum EntranceType
            {
                Profile = 0,
                Showcase = 1,
                Shop = 2
            }
            
            [System.Serializable]
            public enum CreatorType
            {
                Undefined = 0,
                Official = 1,
                Market = 2,
                Normal = 3
            }

            public sealed class ShopEntranceInfo
            {
                public sealed class StoreLabel
                {
                    [System.Serializable]
                    public enum StoreBrandLabelType
                    {
                        None = 0,
                        Official = 1,
                        Authorized = 2,
                        Blue_V = 3,
                        Top_Choice = 4
                    }
                    
                    public sealed class StoreOfficialLabel
                    {
                        public sealed class ShopLabelImage
                        {
                            public readonly int Height;
                            public readonly int Width;
                            public readonly string Minetype;
                            public readonly string ThumbUri;
                            public readonly IReadOnlyList<string> ThumbUriList;
                            public readonly string Uri;
                            public readonly IReadOnlyList<string> UrlList;
                            public readonly string Color;

                            private ShopLabelImage(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel.StoreOfficialLabel.ShopLabelImage img)
                            {
                                Height = img?.Height ?? -1;
                                Width = img?.Width ?? -1;
                                Minetype = img?.Minetype ?? string.Empty;
                                ThumbUri = img?.ThumbUri ?? string.Empty;
                                ThumbUriList = img?.ThumbUriList?.Count > 0 ? new List<string>(img.ThumbUriList) : new List<string>(0);
                                Uri = img?.Uri ?? string.Empty;
                                UrlList = img?.UrlList?.Count > 0 ? new List<string>(img.UrlList) : new List<string>(0);
                                Color = img?.Color ?? string.Empty;
                            }

                            public static implicit operator ShopLabelImage(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel.StoreOfficialLabel.ShopLabelImage img) => new ShopLabelImage(img);
                        }

                        public readonly ShopLabelImage LabelImageLight;
                        public readonly ShopLabelImage LabelImageDark;
                        public readonly StoreBrandLabelType LabelType;
                        public readonly string LabelTypeString;

                        private StoreOfficialLabel(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel.StoreOfficialLabel lbl)
                        {
                            LabelImageLight = lbl?.LabelImageLight;
                            LabelImageDark = lbl?.LabelImageDark;
                            LabelType = lbl?.LabelType != null ? (StoreBrandLabelType)lbl.LabelType : StoreBrandLabelType.None;
                            LabelTypeString = lbl?.LabelTypeStr ?? string.Empty;
                        }

                        public static implicit operator StoreOfficialLabel(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel.StoreOfficialLabel lbl) => new StoreOfficialLabel(lbl);
                    }

                    public readonly StoreOfficialLabel OfficialLabel;
                    public readonly bool IsBytemall;

                    private StoreLabel(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel lbl)
                    {
                        OfficialLabel = lbl?.OfficialLabel;
                        IsBytemall = lbl?.IsBytemall ?? false;
                    }

                    public static implicit operator StoreLabel(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo.StoreLabel lbl) => new StoreLabel(lbl);
                }

                public readonly string ShopId;
                public readonly string ShopName;
                public readonly string ShopRating;
                public readonly StoreLabel Store_Label;
                public readonly string FormatSoldCount;
                public readonly long SoldCount;
                public readonly int ExpRatePercentile;
                public readonly string ExpRateTopDisplay;
                public readonly int RateDisplayStyle;
                public readonly bool ShowRateNotApplicable;

                private ShopEntranceInfo(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo info)
                {
                    ShopId = info?.ShopId ?? string.Empty;
                    ShopName = info?.ShopName ?? string.Empty;
                    ShopRating = info?.ShopRating ?? string.Empty;
                    Store_Label = info?.Store_Label;
                    FormatSoldCount = info?.FormatSoldCount ?? string.Empty;
                    SoldCount = info?.SoldCount ?? -1;
                    ExpRatePercentile = info?.ExpRatePercentile ?? -1;
                    ExpRateTopDisplay = info?.ExpRateTopDisplay ?? string.Empty;
                    RateDisplayStyle = info?.RateDisplayStyle ?? -1;
                    ShowRateNotApplicable = info?.ShowRateNotApplicable ?? false;
                }

                public static implicit operator ShopEntranceInfo(Models.Protobuf.Objects.User.EcommerceEntrance.ShopEntranceInfo info) => new ShopEntranceInfo(info);
            }
            
            public sealed class ShowcaseEntranceInfo
            {
                public readonly string FormatSoldCount;
                public readonly long SoldCount;

                private ShowcaseEntranceInfo(Models.Protobuf.Objects.User.EcommerceEntrance.ShowcaseEntranceInfo info)
                {
                    FormatSoldCount = info?.FormatSoldCount ?? string.Empty;
                    SoldCount = info?.SoldCount ?? -1;
                }

                public static implicit operator ShowcaseEntranceInfo(Models.Protobuf.Objects.User.EcommerceEntrance.ShowcaseEntranceInfo info) => new ShowcaseEntranceInfo(info);
            }
            #endregion

            public readonly EntranceType Entrance_Type;
            public readonly CreatorType Creator_Type;
            public readonly string Schema;
            public readonly ShopEntranceInfo Shop_EntranceInfo;
            public readonly ShowcaseEntranceInfo Showcase_EntranceInfo;

            private EcommerceEntrance(Models.Protobuf.Objects.User.EcommerceEntrance entrance)
            {
                Entrance_Type = entrance?.Entrance_Type != null ? (EntranceType)entrance.Entrance_Type : EntranceType.Profile;
                Creator_Type = entrance?.Creator_Type != null  ? (CreatorType)entrance.Creator_Type : CreatorType.Undefined;
                Schema = entrance?.Schema ?? string.Empty;
                Shop_EntranceInfo = entrance?.Shop_EntranceInfo;
                Showcase_EntranceInfo = entrance?.Showcase_EntranceInfo;
            }

            public static implicit operator EcommerceEntrance(Models.Protobuf.Objects.User.EcommerceEntrance entrance) => new EcommerceEntrance(entrance);
        }
        #endregion

        public readonly long Id;
        /// <summary>
        /// Name set in Profile
        /// </summary>
        public readonly string NickName;
        /// <summary>
        /// User-Description
        /// </summary>
        public readonly string BioDescription;
        /// <summary>
        /// Avatar
        /// </summary>
        public readonly Picture AvatarThumbnail;
        /// <summary>
        /// 720p
        /// </summary>
        public readonly Picture AvatarMedium;
        /// <summary>
        /// 1080p
        /// </summary>
        public readonly Picture AvatarLarge;

        public readonly bool Verified;
        
        public readonly int Status;

        public readonly long CreateTime;

        public readonly long ModifyTime;

        public readonly int Secret;

        public readonly string ShareQRCodeUri;
        
        public readonly IReadOnlyList<Picture> BadgeImages;

        public readonly FollowInfo Follow_Info;

        public readonly PayGrade Pay_Grade;

        public readonly FansClub Fans_Club;

        public readonly Border User_Border;

        public readonly string SpecialId;

        public readonly Picture AvatarBorder;

        public readonly Picture Medal;

        public readonly IReadOnlyList<Picture> RealtimeIconsList;

        public readonly IReadOnlyList<Picture> NewRealTimeIconsList;
        public readonly long TopVipNo;

        public readonly UserAttributes User_Attr;

        public readonly OwnRoom Own_Room;

        public readonly long PayScore;

        public readonly long TicketCount;

        public readonly HostInfo Host_Info;

        public readonly LinkmicStatus LinkMicStats;

        /// <summary>
        /// @-ID for User
        /// <para>
        /// Known as "DisplayId" in backend
        /// </para>
        /// </summary>
        public readonly string UniqueId;
        
        public readonly bool WithCommercePermission;

        public readonly bool WithFusionShopEntry;

        public readonly HostLevel WebcastHostLevel;
        
        public readonly string VerifiedContent;

        public readonly AuthorStats Author_Stats;

        public readonly IReadOnlyList<User> TopFansList;
        public readonly string SecUid;

        public readonly int UserRole;
        

        public readonly ActivityInfo ActivityReward;
        
        public readonly Picture PersonalCard;

        public readonly AuthenticationInfo Authentication_Info;
        
        public readonly IReadOnlyList<Picture> MediaBadgeImages;

        public readonly UserVIPInfo UserVipInfo;

        public readonly IReadOnlyList<long> CommerceWebcastConfigIds;

        public readonly IReadOnlyList<Border> Borders;

        public readonly ComboBadgeInfo ComboBadge_Info;
        public readonly SubscribeInfo Subscribe_Info;

        public readonly IReadOnlyList<Badge> Badges;

        public readonly IReadOnlyList<long> MintTypeLabels;

        public readonly FansClubInfo FansClub_Info;

        public readonly bool AllowFindByContacts;
        public readonly bool AllowOthersDownloadVideo;

        public readonly bool AllowOthersDownloadWhenSharingVideo;

        public readonly bool AllowShareShowProfile;

        public readonly bool AllowShowInGossip;

        public readonly bool AllowShowMyAction;

        public readonly bool AllowStrangeComment;

        public readonly bool AllowUnfollowerComment;

        public readonly bool AllowUseLinkmic;

        public readonly HostLevel Host_Level;

        public readonly Picture AvatarJpg;

        public readonly string BgImgUrl;
        
        public readonly int BlockStatus;

        public readonly int CommentRestrict;
        
        public readonly string Constellation;

        public readonly int DisableIchat;

        public readonly long EnableIchatImg;

        public readonly int Exp;

        public readonly long FanTicketCount;

        public readonly bool FoldStrangerChat;

        public readonly long FollowStatus;
        
        public readonly int IchatRestrictType;

        public readonly string IdString;

        public readonly bool IsFollower;

        public readonly bool IsFollowing;

        public readonly bool NeedProfileGuide;

        public readonly long PayScores;

        public readonly bool PushCommentStatus;
        
        public readonly bool PushDigg;

        public readonly bool PushFollow;

        public readonly bool PushFriendAction;

        public readonly bool PushIchat;
        
        public readonly bool PushStatus;

        public readonly bool PushVideoPost;

        public readonly bool PushVideoRecommend;

        public readonly UserStats Stats;

        public readonly string VerifiedReason;

        public readonly bool WithCarManagementPermission;

        public readonly IReadOnlyList<LiveEventInfo> UpcomingEvents;

        public readonly string ScmLabel;

        public readonly EcommerceEntrance Ecommerce_Entrance;
        
        public readonly bool IsBlock;

        private User(Models.Protobuf.Objects.User user)
        {
            Id = user?.Id ?? -1;
            NickName = user?.NickName ?? string.Empty;
            BioDescription = user?.BioDescription ?? string.Empty;
            AvatarThumbnail = user?.AvatarThumb;
            AvatarMedium = user?.AvatarMedium;
            AvatarLarge = user?.AvatarLarge;
            Verified = user?.Verified ?? false;
            Status = user?.Status ?? -1;
            CreateTime = user?.CreateTime ?? -1;
            ModifyTime = user?.ModifyTime ?? -1;
            Secret = user?.Secret ?? -1;
            ShareQRCodeUri = user?.ShareQRCodeUri ?? string.Empty;
            BadgeImages = user?.BadgeImageList?.Count > 0 ? user.BadgeImageList.Select(p => (Picture)p).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
            Follow_Info = user?.Follow_Info;
            Pay_Grade = user?.Pay_Grade;
            Fans_Club = user?.Fans_Club;
            User_Border = user?.Border;
            SpecialId = user?.SpecialId ?? string.Empty;
            AvatarBorder = user?.AvatarBorder;
            Medal = user?.Medal;
            RealtimeIconsList = user?.RealtimeIconsList?.Count > 0 ? user.RealtimeIconsList.Select(i => (Picture)i).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
            NewRealTimeIconsList = user?.NewRealtimeIconsList?.Count > 0 ? user.NewRealtimeIconsList.Select(i => (Picture)i).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
            TopVipNo = user?.TopVipNo ?? -1;
            User_Attr = user?.User_Attr;
            Own_Room = user?.Own_Room;
            PayScore = user?.PayScore ?? -1;
            TicketCount = user?.TicketCount ?? -1;
            Host_Info = user?.Anchor_Info;
            LinkMicStats = user?.LinkMicStatus ?? LinkmicStatus.Disable;
            UniqueId = user?.DisplayId ?? string.Empty;
            WithCommercePermission = user?.WithCommercePermission ?? false;
            WithFusionShopEntry = user?.WithFusionShopEntry ?? false;
            WebcastHostLevel = user?.WebcastAnchorLevel;
            VerifiedContent = user?.VerifiedContent ?? string.Empty;
            Author_Stats = user?.Author_Stats;
            TopFansList = user?.TopFansList?.Count > 0 ? user.TopFansList.Select(u => (User)u).ToList().AsReadOnly() : new List<User>(0).AsReadOnly();
            SecUid = user?.SecUid ?? string.Empty;
            UserRole = user?.UserRole ?? -1;
            ActivityReward = user?.ActivityReward;
            PersonalCard = user?.PersonalCard;
            Authentication_Info = user?.Authentication_Info;
            MediaBadgeImages = user?.MediaBadgeImageList?.Count > 0 ? user.MediaBadgeImageList.Select(i => (Picture)i).ToList().AsReadOnly() : new List<Picture>(0).AsReadOnly();
            UserVipInfo = user?.UserVipInfo;
            CommerceWebcastConfigIds = user?.CommerceWebcastConfigIdsList?.Count > 0 ? new List<long>(user.CommerceWebcastConfigIdsList).AsReadOnly() : new List<long>(0).AsReadOnly();
            Borders = user?.BorderList?.Count > 0 ? user.BorderList.Select(b => (Border)b).ToList().AsReadOnly() : new List<Border>(0).AsReadOnly();
            ComboBadge_Info = user?.ComboBadge_Info;
            Subscribe_Info = user?.Subscribe_Info;
            Badges = user?.BadgeList?.Count > 0 ? user.BadgeList.Select(b => (Badge)b).ToList().AsReadOnly() : new List<Badge>(0).AsReadOnly();
            MintTypeLabels = user?.MintTypeLabelList?.Count > 0 ? new List<long>(user.MintTypeLabelList).AsReadOnly() : new List<long>(0).AsReadOnly();
            FansClub_Info = user?.FansClub_Info;
            AllowFindByContacts = user?.AllowFindByContacts ?? false;
            AllowOthersDownloadVideo = user?.AllowOthersDownloadVideo ?? false;
            AllowOthersDownloadWhenSharingVideo = user?.AllowOthersDownloadWhenSharingVideo ?? false;
            AllowShareShowProfile = user?.AllowShareShowProfile ?? false;
            AllowShowInGossip = user?.AllowShowInGossip ?? false;
            AllowShowMyAction = user?.AllowShowMyAction ?? false;
            AllowStrangeComment = user?.AllowStrangeComment ?? false;
            AllowUnfollowerComment = user?.AllowUnfollowerComment ?? false;
            AllowUseLinkmic = user?.AllowUseLinkmic ?? false;
            Host_Level = user?.Anchor_Level;
            AvatarJpg = user?.AvatarJpg;
            BgImgUrl = user?.BgImgUrl ?? string.Empty;
            BlockStatus = user?.BlockStatus ?? -1;
            CommentRestrict = user?.CommentRestrict ?? -1;
            Constellation = user?.Constellation ?? string.Empty;
            DisableIchat = user?.DisableIChat ?? -1;
            EnableIchatImg = user?.EnableIChatImg ?? -1;
            Exp = user?.Exp ?? -1;
            FanTicketCount = user?.FanTicketCount ?? -1;
            FoldStrangerChat = user?.FoldStrangerChat ?? false;
            FollowStatus = user?.FollowStatus ?? -1;
            IchatRestrictType = user?.IChatRestrictType ?? -1;
            IdString = user?.IdStr ?? string.Empty;
            IsFollower = user?.IsFollower ?? false;
            IsFollowing = user?.IsFollowing ?? false;
            NeedProfileGuide = user?.NeedProfileGuide ?? false;
            PayScores = user?.PayScores ?? -1;
            PushCommentStatus = user?.PushCommentStatus ?? false;
            PushDigg = user?.PushDigg ?? false;
            PushFollow = user?.PushFollow ?? false;
            PushFriendAction = user?.PushFriendAction ?? false;
            PushIchat = user?.PushIChat ?? false;
            PushStatus = user?.PushStatus ?? false;
            PushVideoPost = user?.PushVideoPost ?? false;
            PushVideoRecommend = user?.PushVideoRecommend ?? false;
            Stats = user?.Stats;
            VerifiedReason = user?.VerifiedReason ?? string.Empty;
            WithCarManagementPermission = user?.WithCarManagementPermission ?? false;
            UpcomingEvents = user?.UpcomingEventList?.Count > 0 ? user.UpcomingEventList.Select(i => (LiveEventInfo)i).ToList().AsReadOnly() : new List<LiveEventInfo>(0).AsReadOnly();
            ScmLabel = user?.ScmLabel ?? string.Empty;
            Ecommerce_Entrance = user?.Ecommerce_Entrance;
            IsBlock = user?.IsBlock ?? false;
        }

        public static implicit operator User(Models.Protobuf.Objects.User user) => new User(user);
    }
}