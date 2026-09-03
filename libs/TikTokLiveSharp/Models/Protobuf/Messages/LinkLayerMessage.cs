using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkLayerMessage : AProtoBase
    {
        public enum CommonContentCase
        {
            Common_Content_Not_Set  = 0,
            Create_Channel_Content = 100,
            List_Change_Content = 102,
            Invite_Content = 103,
            Apply_Content = 104,
            Permit_Apply_Content = 105,
            Reply_Invite_Content = 106,
            Kick_Out_Content = 107,
            Cancel_Apply_Content = 108,
            Cancel_Invite_Content = 109,
            Leave_Content = 110,
            Finish_Content = 111,
            Join_Direct_Content = 112,
            Join_Group_Content = 113,
            Permit_Group_Content = 114,
            Cancel_Group_Content = 115,
            Leave_Group_Content = 116,
            P2P_Group_Change_Content = 117,
            Group_Change_Content = 118
        }

        public CommonContentCase CommonData => (CommonContentCase)oneofCommonContentCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofCommonContentCase;

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public LinkLayerMessageType MessageType { get; }

        [ProtoMember(3)]
        public long ChannelId { get; }

        [ProtoMember(4)]
        public Scene Scene { get; }

        [ProtoMember(100)]
        public CreateChannelContent CreateChannelContent
        {
            get => oneofCommonContentCase.Is(100) ? (CreateChannelContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(100, value);
        }

        [ProtoMember(102)]
        public ListChangeContent ListChangeContent
        {
            get => oneofCommonContentCase.Is(102) ? (ListChangeContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(102, value);
        }

        [ProtoMember(103)]
        public InviteContent InviteContent
        {
            get => oneofCommonContentCase.Is(103) ? (InviteContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(103, value);
        }

        [ProtoMember(104)]
        public ApplyContent ApplyContent
        {
            get => oneofCommonContentCase.Is(104) ? (ApplyContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(104, value);
        }

        [ProtoMember(105)]
        public PermitApplyContent PermitApplyContent
        {
            get => oneofCommonContentCase.Is(105) ? (PermitApplyContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(105, value);
        }

        [ProtoMember(106)]
        public ReplyInviteContent ReplyInviteContent
        {
            get => oneofCommonContentCase.Is(106) ? (ReplyInviteContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(106, value);
        }

        [ProtoMember(107)]
        public KickOutContent KickOutContent
        {
            get => oneofCommonContentCase.Is(107) ? (KickOutContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(107, value);
        }

        [ProtoMember(108)]
        public CancelApplyContent CancelApplyContent
        {
            get => oneofCommonContentCase.Is(108) ? (CancelApplyContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(108, value);
        }

        [ProtoMember(109)]
        public CancelInviteContent CancelInviteContent
        {
            get => oneofCommonContentCase.Is(109) ? (CancelInviteContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(109, value);
        }

        [ProtoMember(110)]
        public LeaveContent LeaveContent
        {
            get => oneofCommonContentCase.Is(110) ? (LeaveContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(110, value);
        }

        [ProtoMember(111)]
        public FinishChannelContent FinishContent
        {
            get => oneofCommonContentCase.Is(111) ? (FinishChannelContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(111, value);
        }

        [ProtoMember(112)]
        public JoinDirectContent JoinDirectContent
        {
            get => oneofCommonContentCase.Is(112) ? (JoinDirectContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(112, value);
        }

        [ProtoMember(113)]
        public JoinGroupContent JoinGroupContent
        {
            get => oneofCommonContentCase.Is(113) ? (JoinGroupContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(113, value);
        }

        [ProtoMember(114)]
        public PermitJoinGroupContent PermitGroupContent
        {
            get => oneofCommonContentCase.Is(114) ? (PermitJoinGroupContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(114, value);
        }

        [ProtoMember(115)]
        public CancelJoinGroupContent CancelGroupContent
        {
            get => oneofCommonContentCase.Is(115) ? (CancelJoinGroupContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(115, value);
        }

        [ProtoMember(116)]
        public LeaveJoinGroupContent LeaveGroupContent
        {
            get => oneofCommonContentCase.Is(116) ? (LeaveJoinGroupContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(116, value);
        }

        [ProtoMember(117)]
        public P2PGroupChangeContent P2PGroupChangeContent
        {
            get => oneofCommonContentCase.Is(117) ? (P2PGroupChangeContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(117, value);
        }

        [ProtoMember(118)]
        public GroupChangeContent GroupChangeContent
        {
            get => oneofCommonContentCase.Is(118) ? (GroupChangeContent)oneofCommonContentCase.Object : default;
            private set => oneofCommonContentCase = new DiscriminatedUnion64Object(118, value);
        }

        [ProtoMember(200)]
        public BusinessContent BusinessContent { get; }
    }
}
