using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LinkerInviteMessageExtra : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class InviterRivalExtra : AProtoBase
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

            [ProtoMember(1)]
            public long TextType { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Text { get; } = string.Empty;

            [ProtoMember(3)]
            [DefaultValue("")]
            public string Label { get; } = string.Empty;

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
        public long MatchType { get; }

        [ProtoMember(2)]
        public long InviteType { get; }

        [ProtoMember(3)]
        public long SubType { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Theme { get; } = string.Empty;

        [ProtoMember(5)]
        public long Duration { get; }

        [ProtoMember(6)]
        public long Layout { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Tips { get; } = string.Empty;

        [ProtoMember(8)]
        public InviterRivalExtra Extra { get; }

        [ProtoMember(9)]
        public List<InviterRivalExtra> OtherUsersList { get; } = new List<InviterRivalExtra>();

        [ProtoMember(10)]
        public CohostTopic TopicInfo { get; }
    }
}
