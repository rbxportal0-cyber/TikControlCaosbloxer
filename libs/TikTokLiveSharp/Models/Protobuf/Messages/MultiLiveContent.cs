using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class MultiLiveContent : AProtoBase
    {
        public enum BusinessCase
        {
            Business_Not_Set = 0,
            Apply_Biz_Content = 1,
            Invite_Biz_Content = 2,
            Reply_Biz_Content = 3,
            Permit_Biz_Content = 4,
            Join_Direct_Biz_Content = 5,
            Kick_Out_Biz_Content = 6
        }

        public BusinessCase BusinessData => (BusinessCase)oneofBusinessCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofBusinessCase;

        [ProtoMember(1)]
        public ApplyBizContent ApplyBizContent
        {
            get => oneofBusinessCase.Is(1) ? (ApplyBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(1, value);
        }

        [ProtoMember(2)]
        public InviteBizContent InviteBizContent
        {
            get => oneofBusinessCase.Is(2) ? (InviteBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(2, value);
        }

        [ProtoMember(3)]
        public ReplyBizContent ReplyBizContent
        {
            get => oneofBusinessCase.Is(3) ? (ReplyBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(3, value);
        }

        [ProtoMember(4)]
        public PermitBizContent PermitBizContent
        {
            get => oneofBusinessCase.Is(4) ? (PermitBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(4, value);
        }

        [ProtoMember(5)]
        public JoinDirectBizContent JoinDirectBizContent
        {
            get => oneofBusinessCase.Is(5) ? (JoinDirectBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(5, value);
        }

        [ProtoMember(6)]
        public KickOutBizContent KickOutBizContent
        {
            get => oneofBusinessCase.Is(6) ? (KickOutBizContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(6, value);
        }
    }
}
