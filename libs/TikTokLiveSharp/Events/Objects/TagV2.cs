using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TagV2
    {
        #region InnerTypes
        [System.Serializable]
        public enum TagClassification
        {
            Unknown = 0,
            CoHostHistory = 1,
            FirstDegreeRelation = 2,
            SecondDegreeRelation = 3
        }

        public sealed class SecondDegreeRelationContent
        {
            public sealed class UserInfo
            {
                public readonly long UserId;
                public readonly string NickName;
                public readonly Picture AvatarThumb;

                private UserInfo(Models.Protobuf.Objects.TagV2.SecondDegreeRelationContent.UserInfo userInfo)
                {
                    UserId = userInfo?.UserId ?? -1;
                    NickName = userInfo?.NickName ?? string.Empty;
                    AvatarThumb = userInfo?.AvatarThumb;
                }

                public static implicit operator UserInfo(Models.Protobuf.Objects.TagV2.SecondDegreeRelationContent.UserInfo userInfo) => new UserInfo(userInfo);
            }

            public readonly IReadOnlyList<UserInfo> RelatedUsers;
            public readonly long RelatedUserCount;

            private SecondDegreeRelationContent(Models.Protobuf.Objects.TagV2.SecondDegreeRelationContent content)
            {
                RelatedUsers = content?.RelatedUsersList?.Count > 0 ? content.RelatedUsersList.Select(u => (UserInfo)u).ToList().AsReadOnly() : new List<UserInfo>(0).AsReadOnly();
                RelatedUserCount = content?.TotalRelatedUserCnt ?? -1;
            }

            public static implicit operator SecondDegreeRelationContent(Models.Protobuf.Objects.TagV2.SecondDegreeRelationContent content) => new SecondDegreeRelationContent(content);
        }
        #endregion

        public readonly TagClassification Classification;
        public readonly int Type;
        public readonly string Value;
        public readonly string StarlingKey;
        public readonly SecondDegreeRelationContent SecondDegreeRelation;
        public readonly long CoHostHistoryDay;

        private TagV2(Models.Protobuf.Objects.TagV2 tag)
        {
            Classification = tag?.Tag_Classification != null ? (TagClassification)tag.Tag_Classification : TagClassification.Unknown;
            Type = tag?.TagType ?? -1;
            Value = tag?.TagValue ?? string.Empty;
            StarlingKey = tag?.StarlingKey ?? string.Empty;
            SecondDegreeRelation = tag?.SecondDegree_RelationContent;
            CoHostHistoryDay = tag?.CohostHistoryDay ?? -1;
        }

        public static implicit operator TagV2(Models.Protobuf.Objects.TagV2 tag) => new TagV2(tag);
    }
}
