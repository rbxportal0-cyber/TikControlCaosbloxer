using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TagV2 : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        [System.Serializable]
        public enum TagClassification
        {
            Unknown = 0,
            CohostHistory = 1,
            FirstDegreeRelation = 2,
            SecondDegreeRelation = 3
        }

        [ProtoContract]
        public partial class SecondDegreeRelationContent : AProtoBase
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
            public List<UserInfo> RelatedUsersList { get; } = new List<UserInfo>();

            [ProtoMember(2)]
            public long TotalRelatedUserCnt { get; }
        }
        #endregion

        public enum ContentCase
        {
            Content_Not_Set = 0,
            Second_Degree_Relation_Content = 10,
            Cohost_History_Day = 11
        }
        public ContentCase GiftData => (ContentCase)oneofContentCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofContentCase;

        [ProtoMember(1)]
        public TagClassification Tag_Classification { get; }

        [ProtoMember(2)]
        public int TagType { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string TagValue { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string StarlingKey { get; } = string.Empty;

        [ProtoMember(10)]
        public SecondDegreeRelationContent SecondDegree_RelationContent
        {
            get => oneofContentCase.Is(10) ? (SecondDegreeRelationContent)oneofContentCase.Object : default;
            private set => oneofContentCase = new DiscriminatedUnion64Object(10, value);
        }

        [ProtoMember(11)]
        public long CohostHistoryDay
        {
            get => oneofContentCase.Is(11) ? (long)oneofContentCase.Object : default;
            private set => oneofContentCase = new DiscriminatedUnion64Object(11, value);
        }
    }
}
