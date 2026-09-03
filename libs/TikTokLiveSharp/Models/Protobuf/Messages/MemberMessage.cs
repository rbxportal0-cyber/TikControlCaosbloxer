using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class MemberMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class EffectConfig : AProtoBase
        {
            [ProtoMember(1)]
            public long Type { get; }

            [ProtoMember(2)]
            public Image Icon { get; }

            [ProtoMember(3)]
            public long AvatarPos { get; }

            [ProtoMember(4)]
            public Text Text { get; }

            [ProtoMember(5)]
            public Image TextIcon { get; }

            [ProtoMember(6)]
            public int StayTime { get; }

            [ProtoMember(7)]
            public long AnimAssetId { get; }

            [ProtoMember(8)]
            public Image Badge { get; }

            [ProtoMember(9)]
            public List<long> FlexSettings { get; } = new List<long>();
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public User User { get; }

        /// <summary>
        /// Available in Join-Message
        /// </summary>
        [ProtoMember(3)]
        public long MemberCount { get; }

        /// <summary>
        /// Usually Host
        /// </summary>
        [ProtoMember(4)]
        public User Operator { get; }

        [ProtoMember(5)]
        public bool IsSetToAdmin { get; }

        [ProtoMember(6)]
        public bool IsTopUser { get; }

        [ProtoMember(7)]
        public long RankScore { get; }

        [ProtoMember(8)]
        public long TopUserNo { get; }

        [ProtoMember(9)]
        public long EnterType { get; }

        [ProtoMember(10)]
        public long Action { get; }

        [ProtoMember(11)] 
        [DefaultValue("")] 
        public string ActionDescription { get; } = string.Empty;

        [ProtoMember(12)]
        public long UserId { get; }

        [ProtoMember(13)]
        public EffectConfig Effect_Config { get; }

        [ProtoMember(14)] 
        [DefaultValue("")] 
        public string PopStr { get; } = string.Empty;

        [ProtoMember(15)]
        public EffectConfig EnterEffectConfig { get; }

        [ProtoMember(16)]
        public Image BackgroundImage { get; }

        [ProtoMember(17)] 
        public Image BackgroundImageV2 { get; }

        /// <summary>
        /// Identical to details in Header
        /// </summary>
        [ProtoMember(18)]
        public Text AnchorDisplayText { get; }

        /// <summary>
        /// unknown/homepage_hot-live_cell.live_merge-live_cover
        /// </summary>
        [ProtoMember(19)]
        [DefaultValue("")]
        public string ClientEnterSource { get; } = string.Empty;

        /// <summary>
        /// click/draw
        /// </summary>
        [ProtoMember(20)]
        [DefaultValue("")]
        public string ClientEnterType { get; } = string.Empty;

        /// <summary>
        /// rec
        /// </summary>
        [ProtoMember(21)]
        [DefaultValue("")]
        public string ClientLiveReason { get; } = string.Empty;

        [ProtoMember(22)]
        public long ActionDuration { get; }

        /// <summary>
        /// other
        /// </summary>
        [ProtoMember(23)]
        [DefaultValue("")]
        public string UserShareType { get; } = string.Empty;
        
        [ProtoMember(24)] 
        public DisplayStyle DisplayStyle { get; }

        [ProtoMember(25)]
        public Dictionary<int, int> AdminPermissionsMap { get; } = new Dictionary<int, int>();

        [ProtoMember(26)]
        public int KickSource { get; }

        [ProtoMember(27)]
        public long AllowPreviewTime { get; }
    }
}
