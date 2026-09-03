using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class JoinGroupMessageExtra : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class RivalExtra : AProtoBase
        {
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

            [ProtoMember(4)]
            public long UserCount { get; }

            [ProtoMember(5)]
            public Image AvatarThumb { get; }

            [ProtoMember(6)]
            [DefaultValue("")]
            public string DisplayId { get; } = string.Empty;

            [ProtoMember(7)]
            public AuthenticationInfo Authentication_Info { get; }

            [ProtoMember(8)]
            [DefaultValue("")]
            public string NickName { get; } = string.Empty;

            [ProtoMember(9)]
            public long FollowStatus { get; }

            [ProtoMember(10)]
            public Hashtag Hashtag { get; }

            [ProtoMember(11)]
            public TopHostInfo TopHostInfo { get; }

            [ProtoMember(12)]
            public long UserId { get; }

            [ProtoMember(13)]
            public bool IsBestTeammate { get; }
        }
        #endregion

        [ProtoMember(1)]
        public long SourceType { get; }

        [ProtoMember(2)]
        public RivalExtra Extra { get; }

        [ProtoMember(3)]
        public List<RivalExtra> OtherUsersList { get; } = new List<RivalExtra>();
    }
}
