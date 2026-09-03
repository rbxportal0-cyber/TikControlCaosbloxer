using TikTokLiveSharp.Events.Data;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class LinkLayerMessage : AMessageData
    {
        public enum Data
        {
            None = 0,
            Create_Channel = 100,
            List_Change = 102,
            Invite = 103,
            Apply = 104,
            Permit_Apply = 105,
            Reply_Invite = 106,
            Kick_Out = 107,
            Cancel_Apply = 108,
            Cancel_Invite = 109,
            Leave = 110,
            Finish = 111,
            Join_Direct = 112,
            Join_Group = 113,
            Permit_Group = 114,
            Cancel_Group = 115,
            Leave_Group = 116,
            P2P_Group_Change = 117,
            Group_Change = 118
        }

        /// <summary>
        /// Describes which Data is set
        /// <para>
        /// All other values are NULL
        /// </para>
        /// </summary>
        public readonly Data DataType;

        public readonly LinkLayerMessageType MessageType;
        public readonly long ChannelId;
        public readonly Scene Scene;
        public readonly BusinessContent BusinessContent;

        // Only 1 of the types below will not be NULL
        // Which one this is can be checked by using <see cref="DataType"/>
        public readonly CreateChannelContent CreateChannelContent;
        public readonly ListChangeContent ListChangeContent;
        public readonly InviteContent InviteContent;
        public readonly ApplyContent ApplyContent;
        public readonly PermitApplyContent PermitApplyContent;
        public readonly ReplyInviteContent ReplyInviteContent;
        public readonly KickOutContent KickOutContent;
        public readonly CancelApplyContent CancelApplyContent;
        public readonly CancelInviteContent CancelInviteContent;
        public readonly LeaveContent LeaveContent;
        public readonly FinishChannelContent FinishContent;
        public readonly JoinDirectContent JoinDirectContent;
        public readonly JoinGroupContent JoinGroupContent;
        public readonly PermitJoinGroupContent PermitGroupContent;
        public readonly CancelJoinGroupContent CancelGroupContent;
        public readonly LeaveJoinGroupContent LeaveGroupContent;
        public readonly P2PGroupChangeContent P2PGroupChangeContent;
        public readonly GroupChangeContent GroupChangeContent;

        internal LinkLayerMessage(Models.Protobuf.Messages.LinkLayerMessage message) : base(message?.Header)
        {
            DataType = message?.CommonData != null ? (Data)message.CommonData : Data.None;
            MessageType = message?.MessageType ?? LinkLayerMessageType.Linker_Unknown;
            ChannelId = message?.ChannelId ?? -1;
            Scene = message?.Scene ?? Scene.Scene_Unknown;
            BusinessContent = message?.BusinessContent;

            CreateChannelContent = DataType == Data.Create_Channel ? message?.CreateChannelContent : null;
            ListChangeContent = DataType == Data.List_Change ? message?.ListChangeContent : null;
            InviteContent = DataType == Data.Invite ? message?.InviteContent : null;
            ApplyContent = DataType == Data.Apply ? message?.ApplyContent : null;
            PermitApplyContent = DataType == Data.Permit_Apply ? message?.PermitApplyContent : null;
            ReplyInviteContent = DataType == Data.Reply_Invite ? message?.ReplyInviteContent : null;
            KickOutContent = DataType == Data.Kick_Out ? message?.KickOutContent : null;
            CancelApplyContent = DataType == Data.Cancel_Apply ? message?.CancelApplyContent : null;
            CancelInviteContent = DataType == Data.Invite ? message?.CancelInviteContent : null;
            LeaveContent = DataType == Data.Leave ? message?.LeaveContent : null;
            FinishContent = DataType == Data.Finish ? message?.FinishContent : null;
            JoinDirectContent = DataType == Data.Join_Direct ? message?.JoinDirectContent : null;
            JoinGroupContent = DataType == Data.Join_Group ? message?.JoinGroupContent : null;
            PermitGroupContent = DataType == Data.Permit_Group ? message?.PermitGroupContent : null;
            CancelGroupContent = DataType == Data.Cancel_Group ? message?.CancelGroupContent : null;
            LeaveGroupContent = DataType == Data.Leave_Group ? message?.LeaveGroupContent : null;
            P2PGroupChangeContent = DataType == Data.P2P_Group_Change ? message?.P2PGroupChangeContent : null;
            GroupChangeContent = DataType == Data.Group_Change ? message?.GroupChangeContent : null;
        }
    }
}
