using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class User : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class FollowInfo : AProtoBase
        {
            [ProtoMember(1)]
            public long FollowingCount { get; }

            [ProtoMember(2)]
            public long FollowerCount { get; }

            [ProtoMember(3)]
            public long FollowStatus { get; }

            [ProtoMember(4)]
            public long PushStatus { get; }
        }

        [ProtoContract]
        public partial class PayGrade : AProtoBase
        {
            [ProtoContract]
            public partial class GradeIcon : AProtoBase
            {
                [ProtoMember(1)]
                public Image Icon { get; }

                [ProtoMember(2)]
                public long IconDiamond { get; }

                [ProtoMember(3)]
                public long Level { get; }

                [ProtoMember(4)]
                [DefaultValue("")]
                public string LevelStr { get; }
            }

            [ProtoMember(1)]
            public long Deprecated20 { get; }

            [ProtoMember(2)]
            public Image DiamondIcon { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string Name { get; } = string.Empty;

            [ProtoMember(4)]
            public Image Icon { get; }

            [ProtoMember(5)]
            [DefaultValue("")]
            public string NextName { get; }

            [ProtoMember(6)]
            public long Level { get; }

            [ProtoMember(7)]
            public Image NextIcon { get; }

            [ProtoMember(8)]
            public long Deprecated22 { get; }

            [ProtoMember(9)]
            public long Deprecated23 { get; }

            [ProtoMember(10)]
            public long Deprecated24 { get; }

            [ProtoMember(11)]
            public long Deprecated25 { get; }

            [ProtoMember(12)]
            public long Deprecated26 { get; }

            [ProtoMember(13)]
            [DefaultValue("")]
            public string GradeDescribe { get; } = string.Empty;

            [ProtoMember(14)]
            public List<GradeIcon> GradeIconList { get; } = new List<GradeIcon>();

            [ProtoMember(15)]
            public long ScreenChatType { get; }

            [ProtoMember(16)]
            public Image ImIcon { get; }

            [ProtoMember(17)]
            public Image ImIconWithLevel { get; }

            [ProtoMember(18)]
            public Image LiveIcon { get; }

            [ProtoMember(19)]
            public Image NewImIconWithLevel { get; }

            [ProtoMember(20)]
            public Image NewLiveIcon { get; }

            [ProtoMember(21)]
            public long UpgradeNeedConsume { get; }

            [ProtoMember(22)]
            [DefaultValue("")]
            public string NextPrivileges { get; } = string.Empty;

            [ProtoMember(23)]
            public Image Background { get; }

            [ProtoMember(24)]
            public Image BackgroundBack { get; }

            [ProtoMember(25)]
            public long Score { get; }

            [ProtoMember(1001)]
            [DefaultValue("")]
            public string GradeBanner { get; } = string.Empty;

            [ProtoMember(1002)]
            public Image ProfileDialogBg { get; }

            [ProtoMember(1003)]
            public Image ProfileDialogBgBack { get; }
        }

        [ProtoContract]
        public partial class FansClub : AProtoBase
        {
            [ProtoContract]
            public partial class FansClubData : AProtoBase
            {
                #region InnerTypes
                [ProtoContract]
                [System.Serializable]
                public enum BadgeIcon
                {
                    Unknown = 0,
                    Icon = 1,
                    SmallIcon = 2
                }

                [ProtoContract]
                [System.Serializable]
                public enum UserFansClubStatus
                {
                    NotJoined = 0,
                    Active = 1,
                    Inactive = 2
                }

                [ProtoContract]
                public partial class UserBadge : AProtoBase
                {
                    [ProtoMember(1)]
                    public Dictionary<int, Image> IconsMap { get; }

                    [ProtoMember(2)]
                    [DefaultValue("")]
                    public string Title { get; } = string.Empty;
                }
                #endregion

                [ProtoMember(1)]
                [DefaultValue("")]
                public string ClubName { get; } = string.Empty;

                [ProtoMember(2)]
                public int Level { get; }

                [ProtoMember(3)]
                public UserFansClubStatus FansClubStatus { get; }

                [ProtoMember(4)]
                public UserBadge Badge { get; }

                [ProtoMember(5)]
                public List<long> AvailableGiftIdsList { get; } = new List<long>();

                [ProtoMember(6)]
                public long AnchorId { get; }
            }

            [ProtoContract]
            [System.Serializable]
            public enum PreferentialType
            {
                PersonalProfile = 0,
                OtherRoom = 1
            }

            [ProtoMember(1)]
            public FansClubData Data { get; }

            [ProtoMember(2)]
            public Dictionary<int, FansClubData> PreferDataMap { get; } = new Dictionary<int, FansClubData>();
        }

        [ProtoContract]
        public partial class OwnRoom : AProtoBase
        {
            [ProtoMember(1)]
            public List<long> RoomIdsList { get; } = new List<long>();

            [ProtoMember(2)]
            public List<string> RoomIdsStrList { get; } = new List<string>();
        }
        
        [ProtoContract]
        public partial class AnchorLevel : AProtoBase
        {
            [ProtoMember(1)]
            public long Level { get; }

            [ProtoMember(2)]
            public long Experience { get; }

            [ProtoMember(3)]
            public long LowestExperienceThisLevel { get; }

            [ProtoMember(4)]
            public long HighestExperienceThisLevel { get; }

            [ProtoMember(5)]
            public long TaskStartExperience { get; }

            [ProtoMember(6)]
            public long TaskStartTime { get; }

            [ProtoMember(7)]
            public long TaskDecreaseExperience { get; }

            [ProtoMember(8)]
            public long TaskTargetExperience { get; }

            [ProtoMember(9)]
            public long TaskEndTime { get; }

            [ProtoMember(10)]
            public Image ProfileDialogBg { get; }

            [ProtoMember(11)]
            public Image ProfileDialogBgBack { get; }

            [ProtoMember(12)]
            public Image StageLevel { get; }

            [ProtoMember(13)]
            public Image SmallIcon { get; }
        }

        [ProtoContract]
        public partial class AuthorStats : AProtoBase
        {
            [ProtoMember(1)]
            public long VideoTotalCount { get; }

            [ProtoMember(2)]
            public long VideoTotalPlayCount { get; }

            [ProtoMember(3)]
            public long VideoTotalShareCount { get; }

            [ProtoMember(4)]
            public long VideoTotalSeriesCount { get; }

            [ProtoMember(5)]
            public long VarietyShowPlayCount { get; }

            [ProtoMember(6)]
            public long VideoTotalFavoriteCount { get; }
        }

        [ProtoContract]
        public partial class DeprecatedType1 : AProtoBase
        {
            [ProtoContract]
            public partial class DeprecatedType2 : AProtoBase
            {
                [ProtoContract]
                public partial class DeprecatedType3 : AProtoBase
                {
                    [ProtoMember(1)]
                    [DefaultValue("")]
                    public string Deprecated1 { get; } = string.Empty;

                    [ProtoMember(2)]
                    [DefaultValue("")]
                    public string Deprecated2 { get; } = string.Empty;

                    [ProtoMember(3)]
                    [DefaultValue("")]
                    public string Deprecated3 { get; } = string.Empty;
                }

                [ProtoMember(1)]
                [DefaultValue("")]
                public string Deprecated1 { get; } = string.Empty;

                [ProtoMember(2)]
                [DefaultValue("")]
                public string Deprecated2 { get; } = string.Empty;

                [ProtoMember(3)]
                public DeprecatedType3 Deprecated3 { get; }
            }

            [ProtoMember(1)]
            [DefaultValue("")]
            public string Deprecated1 { get; } = string.Empty;

            [ProtoMember(2)]
            public long Deprecated2 { get; }

            [ProtoMember(3)]
            public long Deprecated3 { get; }

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated4 { get; } = string.Empty;

            [ProtoMember(5)]
            [DefaultValue("")]
            public string Deprecated5 { get; } = string.Empty;

            [ProtoMember(6)]
            public bool Deprecated6 { get; }

            [ProtoMember(7)]
            public DeprecatedType2 Deprecated7 { get; }
        }

        [ProtoContract]
        public partial class ActivityInfo : AProtoBase
        {
            [ProtoMember(1)]
            public Image Badge { get; }

            [ProtoMember(2)]
            public Image StoryTag { get; }
        }

        [ProtoContract]
        public partial class DeprecatedType4 : AProtoBase
        {
            [ProtoMember(1)]
            public Image Deprecated1 { get; }

            [ProtoMember(2)]
            public long Deprecated2 { get; }

            [ProtoMember(3)]
            public Image Deprecated3 { get; }

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated4 { get; } = string.Empty;

            [ProtoMember(5)]
            public long Deprecated5 { get; }

            [ProtoMember(6)]
            public Image Deprecated6 { get; }

            [ProtoMember(7)]
            public Image Deprecated7 { get; }

            [ProtoMember(8)]
            public Image Deprecated8 { get; }

            [ProtoMember(9)]
            public List<string> Deprecated9List { get; } = new List<string>();
        }

        [ProtoContract]
        public partial class DeprecatedType5 : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Deprecated1 { get; } = string.Empty;

            [ProtoMember(2)]
            public long Deprecated2 { get; }

            [ProtoMember(3)]
            public Image Deprecated3 { get; }

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated4 { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class AuthenticationInfo : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string CustomVerify { get; } = string.Empty;

            [ProtoMember(2)]
            [DefaultValue("")]
            public string EnterpriseVerifyReason { get; } = string.Empty;

            [ProtoMember(3)]
            public Image AuthenticationBadge { get; }
        }

        [ProtoContract]
        public partial class DeprecatedType6 : AProtoBase
        {
            [ProtoMember(1)]
            public bool Deprecated1 { get; }

            [ProtoMember(2)]
            public long Deprecated2 { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string Deprecated3 { get; } = string.Empty;

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Deprecated4 { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class ComboBadgeInfo : AProtoBase
        {
            [ProtoMember(1)]
            public Image Icon { get; }

            [ProtoMember(2)]
            public long ComboCount { get; }
        }

        [ProtoContract]
        public partial class SubscribeBadge : AProtoBase
        {
            [ProtoMember(1)]
            public Image OriginImg { get; }

            [ProtoMember(2)]
            public Image PreviewImg { get; }
        }

        [ProtoContract]
        public partial class SubscribeInfo : AProtoBase
        {
            [ProtoMember(1)]
            public bool Qualification { get; }

            [ProtoMember(2)]
            public bool IsSubscribe { get; }

            [ProtoMember(3)]
            public SubscribeBadge Badge { get; }

            [ProtoMember(4)]
            public bool EnableSubscription { get; }

            [ProtoMember(5)]
            public long SubscriberCount { get; }

            [ProtoMember(6)]
            public bool IsInGracePeriod { get; }

            [ProtoMember(7)]
            public bool IsSubscribedToAnchor { get; }

            [ProtoMember(8)]
            public TimerDetail TimerDetail { get; }

            [ProtoMember(9)]
            public bool UserGiftSubAuth { get; }

            [ProtoMember(10)]
            public bool AnchorGiftSubAuth { get; }
        }

        [ProtoContract]
        public partial class FansClubInfo : AProtoBase
        {
            [ProtoMember(1)]
            public bool IsSleeping { get; }

            [ProtoMember(2)]
            public long FansLevel { get; }

            [ProtoMember(3)]
            public long FansScore { get; }

            [ProtoMember(4)]
            public Image Badge { get; }

            [ProtoMember(5)]
            public long FansCount { get; }
        }

        [ProtoContract]
        public partial class UserStats : AProtoBase
        {
            [ProtoMember(1)]
            public long Id { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string IdStr { get; } = string.Empty;

            [ProtoMember(3)]
            public long FollowingCount { get; }

            [ProtoMember(4)]
            public long FollowerCount { get; }

            [ProtoMember(5)]
            public long RecordCount { get; }

            [ProtoMember(6)]
            public long TotalDuration { get; }

            [ProtoMember(7)]
            public long DailyFanTicketCount { get; }

            [ProtoMember(8)]
            public long DailyIncome { get; }

            [ProtoMember(9)]
            public long ItemCount { get; }

            [ProtoMember(10)]
            public long FavoriteItemCount { get; }

            [ProtoMember(11)]
            public long Deprecated27 { get; }

            [ProtoMember(12)]
            public long DiamondConsumedCount { get; }

            [ProtoMember(13)]
            public long TuwenItemCount { get; }
        }

        [ProtoContract]
        public partial class EcommerceEntrance : AProtoBase
        {
            #region InnerTypes
            [ProtoContract]
            [System.Serializable]
            public enum EntranceType
            {
                Profile = 0,
                Showcase = 1,
                Shop = 2
            }

            [ProtoContract]
            [System.Serializable]
            public enum CreatorType
            {
                Undefined = 0,
                Official = 1,
                Market = 2,
                Normal = 3
            }

            [ProtoContract]
            public partial class ShopEntranceInfo : AProtoBase
            {
                [ProtoContract]
                public partial class StoreLabel : AProtoBase
                {
                    [ProtoContract]
                    [System.Serializable]
                    public enum StoreBrandLabelType
                    {
                        None = 0,
                        Official = 1,
                        Authorized = 2,
                        Store_Brand_Label_Type_Blue_V = 3,
                        Store_Brand_Label_Type_Top_Choice = 4
                    }

                    [ProtoContract]
                    public partial class StoreOfficialLabel : AProtoBase
                    {
                        [ProtoContract]
                        public partial class ShopLabelImage : AProtoBase
                        {
                            [ProtoMember(1)]
                            public int Height { get; }

                            [ProtoMember(2)]
                            public int Width { get; }

                            [ProtoMember(3)]
                            [DefaultValue("")]
                            public string Minetype { get; } = string.Empty;

                            [ProtoMember(4)]
                            [DefaultValue("")]
                            public string ThumbUri { get; } = string.Empty;

                            [ProtoMember(5)]
                            public List<string> ThumbUriList { get; } = new List<string>();

                            [ProtoMember(6)]
                            [DefaultValue("")]
                            public string Uri { get; } = string.Empty;

                            [ProtoMember(7)]
                            public List<string> UrlList { get; } = new List<string>();

                            [ProtoMember(8)]
                            [DefaultValue("")]
                            public string Color { get; } = string.Empty;
                        }

                        [ProtoMember(1)]
                        public ShopLabelImage LabelImageLight { get; }

                        [ProtoMember(2)]
                        public ShopLabelImage LabelImageDark { get; }

                        [ProtoMember(3)]
                        public StoreBrandLabelType LabelType { get; }

                        [ProtoMember(4)]
                        [DefaultValue("")]
                        public string LabelTypeStr { get; } = string.Empty;
                    }

                    [ProtoMember(1)]
                    public StoreOfficialLabel OfficialLabel { get; }

                    [ProtoMember(2)]
                    public bool IsBytemall { get; }
                }

                [ProtoMember(1)]
                [DefaultValue("")]
                public string ShopId { get; } = string.Empty;

                [ProtoMember(2)]
                [DefaultValue("")]
                public string ShopName { get; } = string.Empty;

                [ProtoMember(3)]
                [DefaultValue("")]
                public string ShopRating { get; } = string.Empty;

                [ProtoMember(4)]
                public StoreLabel Store_Label { get; }

                [ProtoMember(5)]
                [DefaultValue("")]
                public string FormatSoldCount { get; } = string.Empty;

                [ProtoMember(6)]
                public long SoldCount { get; }

                [ProtoMember(7)]
                public int ExpRatePercentile { get; }

                [ProtoMember(8)]
                [DefaultValue("")]
                public string ExpRateTopDisplay { get; } = string.Empty;

                [ProtoMember(9)]
                public int RateDisplayStyle { get; }

                [ProtoMember(10)]
                public bool ShowRateNotApplicable { get; }
            }

            [ProtoContract]
            public partial class ShowcaseEntranceInfo : AProtoBase
            {
                [ProtoMember(1)]
                [DefaultValue("")]
                public string FormatSoldCount { get; } = string.Empty;

                [ProtoMember(2)]
                public long SoldCount { get; }
            }
            #endregion

            [ProtoMember(1)]
            public EntranceType Entrance_Type { get; }

            [ProtoMember(2)]
            public CreatorType Creator_Type { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string Schema { get; } = string.Empty;

            [ProtoMember(4)]
            public ShopEntranceInfo Shop_EntranceInfo { get; }

            [ProtoMember(5)]
            public ShowcaseEntranceInfo Showcase_EntranceInfo { get; }
        }
        #endregion

        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public long Deprecated1 { get; }

        /// <summary>
        /// Name set in Profile
        /// </summary>
        [ProtoMember(3)]
        [DefaultValue("")]
        public string NickName { get; } = string.Empty;

        [ProtoMember(4)]
        public int Deprecated2 { get; }

        /// <summary>
        /// User-Description
        /// </summary>
        [ProtoMember(5)]
        [DefaultValue("")]
        public string BioDescription { get; } = string.Empty;

        [ProtoMember(6)]
        public int Deprecated3 { get; }

        [ProtoMember(7)]
        public long Deprecated4 { get; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Deprecated5 { get; } = string.Empty;

        /// <summary>
        /// Avatar
        /// </summary>
        [ProtoMember(9)]
        public Image AvatarThumb { get; }

        /// <summary>
        /// 720p
        /// </summary>
        [ProtoMember(10)]
        public Image AvatarMedium { get; }

        /// <summary>
        /// 1080p
        /// </summary>
        [ProtoMember(11)]
        public Image AvatarLarge { get; }

        [ProtoMember(12)]
        public bool Verified { get; }

        [ProtoMember(13)]
        public int Deprecated6 { get; }

        [ProtoMember(14)]
        [DefaultValue("")]
        public string Deprecated7 { get; } = string.Empty;

        [ProtoMember(15)]
        public int Status { get; }

        [ProtoMember(16)]
        public long CreateTime { get; }

        [ProtoMember(17)]
        public long ModifyTime { get; }

        [ProtoMember(18)]
        public int Secret { get; }

        [ProtoMember(19)]
        [DefaultValue("")]
        public string ShareQRCodeUri { get; } = string.Empty;

        [ProtoMember(20)]
        public int Deprecated8 { get; }
        
        [ProtoMember(21)]
        public List<Image> BadgeImageList { get; } = new List<Image>();

        [ProtoMember(22)]
        public FollowInfo Follow_Info { get; }

        [ProtoMember(23)]
        public PayGrade Pay_Grade { get; }

        [ProtoMember(24)]
        public FansClub Fans_Club { get; }
        
        [ProtoMember(25)]
        public BorderInfo Border { get; }

        [ProtoMember(26)]
        [DefaultValue("")]
        public string SpecialId { get; } = string.Empty;

        [ProtoMember(27)]
        public Image AvatarBorder { get; }

        [ProtoMember(28)]
        public Image Medal { get; }

        [ProtoMember(29)]
        public List<Image> RealtimeIconsList { get; } = new List<Image>();
        
        [ProtoMember(30)]
        public List<Image> NewRealtimeIconsList { get; } = new List<Image>();

        [ProtoMember(31)]
        public long TopVipNo { get; }

        [ProtoMember(32)]
        public UserAttr User_Attr { get; }

        [ProtoMember(33)]
        public OwnRoom Own_Room { get; }

        [ProtoMember(34)]
        public long PayScore { get; }

        [ProtoMember(35)]
        public long TicketCount { get; }

        [ProtoMember(36)]
        public AnchorInfo Anchor_Info { get; }
        
        [ProtoMember(37)]
        public LinkmicStatus LinkMicStatus { get; }

        /// <summary>
        /// @-ID for User
        /// </summary>
        [ProtoMember(38)]
        [DefaultValue("")]
        public string DisplayId { get; } = string.Empty;

        [ProtoMember(39)]
        public bool WithCommercePermission { get; }

        [ProtoMember(40)]
        public bool WithFusionShopEntry { get; }

        [ProtoMember(41)]
        public long Deprecated21 { get; }

        [ProtoMember(42)]
        public AnchorLevel WebcastAnchorLevel { get; }

        [ProtoMember(43)]
        [DefaultValue("")]
        public string VerifiedContent { get; } = string.Empty;

        [ProtoMember(44)]
        public AuthorStats Author_Stats { get; }

        [ProtoMember(45)]
        public List<User> TopFansList { get; } = new List<User>();

        [ProtoMember(46)]
        [DefaultValue("")]
        public string SecUid { get; } = string.Empty;

        [ProtoMember(47)]
        public int UserRole { get; }

        [ProtoMember(48)]
        public DeprecatedType1 Deprecated9 { get; }

        [ProtoMember(49)]
        public ActivityInfo ActivityReward { get; }

        [ProtoMember(50)]
        public DeprecatedType4 Deprecated10 { get; }

        [ProtoMember(51)]
        public DeprecatedType5 Deprecated11 { get; }

        [ProtoMember(52)]
        public Image PersonalCard { get; }

        [ProtoMember(53)]
        public AuthenticationInfo Authentication_Info { get; }

        [ProtoMember(54)]
        public int Deprecated12 { get; }

        [ProtoMember(55)]
        public int Deprecated13 { get; }

        [ProtoMember(56)]
        public DeprecatedType6 Deprecated14 { get; }
        
        [ProtoMember(57)]
        public List<Image> MediaBadgeImageList { get; } = new List<Image>();

        [ProtoMember(58)]
        public int Deprecated15 { get; }

        [ProtoMember(59)]
        public UserVIPInfo UserVipInfo { get; }
        
        [ProtoMember(60)]
        public List<long> CommerceWebcastConfigIdsList { get; } = new List<long>();
        
        [ProtoMember(61)]
        public List<BorderInfo> BorderList { get; } = new List<BorderInfo>();

        [ProtoMember(62)]
        public ComboBadgeInfo ComboBadge_Info { get; }

        [ProtoMember(63)]
        public SubscribeInfo Subscribe_Info { get; }
        
        [ProtoMember(64)]
        public List<BadgeStruct> BadgeList { get; } = new List<BadgeStruct>();

        [ProtoMember(65)]
        public List<long> MintTypeLabelList { get; } = new List<long>();

        [ProtoMember(66)]
        public FansClubInfo FansClub_Info { get; }

        [ProtoMember(1001)]
        public bool Deprecated19 { get; }

        [ProtoMember(1002)]
        public bool AllowFindByContacts { get; }

        [ProtoMember(1003)]
        public bool AllowOthersDownloadVideo { get; }

        [ProtoMember(1004)]
        public bool AllowOthersDownloadWhenSharingVideo { get; }

        [ProtoMember(1005)]
        public bool AllowShareShowProfile { get; }

        [ProtoMember(1006)]
        public bool AllowShowInGossip { get; }

        [ProtoMember(1007)]
        public bool AllowShowMyAction { get; }

        [ProtoMember(1008)]
        public bool AllowStrangeComment { get; }

        [ProtoMember(1009)]
        public bool AllowUnfollowerComment { get; }

        [ProtoMember(1010)]
        public bool AllowUseLinkmic { get; }

        [ProtoMember(1011)]
        public AnchorLevel Anchor_Level { get; }

        [ProtoMember(1012)]
        public Image AvatarJpg { get; }

        [ProtoMember(1013)]
        [DefaultValue("")]
        public string BgImgUrl { get; } = string.Empty;

        [ProtoMember(1014)]
        [DefaultValue("")]
        public string Deprecated18 { get; } = string.Empty;

        [ProtoMember(1015)]
        public bool Deprecated16 { get; }

        [ProtoMember(1016)]
        public int BlockStatus { get; }

        [ProtoMember(1017)]
        public int CommentRestrict { get; }

        [ProtoMember(1018)]
        [DefaultValue("")]
        public string Constellation { get; } = string.Empty;

        [ProtoMember(1019)]
        public int DisableIChat { get; }

        [ProtoMember(1020)]
        public long EnableIChatImg { get; }

        [ProtoMember(1021)]
        public int Exp { get; }

        [ProtoMember(1022)]
        public long FanTicketCount { get; }

        [ProtoMember(1023)]
        public bool FoldStrangerChat { get; }

        [ProtoMember(1024)]
        public long FollowStatus { get; }

        [ProtoMember(1025)]
        public bool Deprecated28 { get; }

        [ProtoMember(1026)]
        [DefaultValue("")]
        public string Deprecated29 { get; } = string.Empty;

        [ProtoMember(1027)]
        public int IChatRestrictType { get; }

        [ProtoMember(1028)]
        [DefaultValue("")]
        public string IdStr { get; } = string.Empty;

        [ProtoMember(1029)]
        public bool IsFollower { get; }

        [ProtoMember(1030)]
        public bool IsFollowing { get; }

        [ProtoMember(1031)]
        public bool NeedProfileGuide { get; }

        [ProtoMember(1032)]
        public long PayScores { get; }

        [ProtoMember(1033)]
        public bool PushCommentStatus { get; }

        [ProtoMember(1034)]
        public bool PushDigg { get; }

        [ProtoMember(1035)]
        public bool PushFollow { get; }

        [ProtoMember(1036)]
        public bool PushFriendAction { get; }

        [ProtoMember(1037)]
        public bool PushIChat { get; }

        [ProtoMember(1038)]
        public bool PushStatus { get; }

        [ProtoMember(1039)]
        public bool PushVideoPost { get; }

        [ProtoMember(1040)]
        public bool PushVideoRecommend { get; }

        [ProtoMember(1041)]
        public UserStats Stats { get; }

        [ProtoMember(1042)]
        public bool Deprecated17 { get; }

        [ProtoMember(1043)]
        [DefaultValue("")]
        public string VerifiedReason { get; } = string.Empty;

        [ProtoMember(1044)]
        public bool WithCarManagementPermission { get; }
        
        [ProtoMember(1045)]
        public List<LiveEventInfo> UpcomingEventList { get; } = new List<LiveEventInfo>();

        [ProtoMember(1046)]
        [DefaultValue("")]
        public string ScmLabel { get; } = string.Empty;

        [ProtoMember(1047)]
        public EcommerceEntrance Ecommerce_Entrance { get; }

        [ProtoMember(1048)]
        public bool IsBlock { get; }
    }
}
