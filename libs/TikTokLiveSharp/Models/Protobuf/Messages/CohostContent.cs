using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CohostContent : AProtoBase
    {
        public enum BusinessCase
        {
            Business_Not_Set = 0,
            Join_Group_Biz_Content = 1,
            Permit_Join_Group_Biz_Content = 2,
            List_Change_Biz_Content = 11
        }
        
        public BusinessCase MsgContent => (BusinessCase)oneofBusinessCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofBusinessCase;

        [ProtoMember(1)]
        public JoinGroupBizContent JoinGroupBizContent
        {
            get => oneofBusinessCase.Is(1) ? (JoinGroupBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(1, value);
        }

        [ProtoMember(2)]
        public PermitJoinGroupBizContent PermitJoinGroupBizContent
        {
            get => oneofBusinessCase.Is(2) ? (PermitJoinGroupBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(2, value);
        }

        [ProtoMember(11)]
        public ListChangeBizContent ListChangeBizContent
        {
            get => oneofBusinessCase.Is(11) ? (ListChangeBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(11, value);
        }
    }
}
