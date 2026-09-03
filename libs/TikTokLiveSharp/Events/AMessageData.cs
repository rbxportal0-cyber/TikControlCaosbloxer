using System.Collections.Generic;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Basic MessageData (Header-Data)
    /// </summary>
    public abstract class AMessageData
    {
        [System.Serializable]
        public enum IMDispatchStrategy
        {
            Default = 0,
            Bypass_Dispatch_Queue = 1
        }

        /// <summary>
        /// ID for Message
        /// </summary>
        public readonly long MessageId;
        /// <summary>
        /// ID for Room that sent this Message
        /// </summary>
        public readonly long RoomId;
        /// <summary>
        /// Unix-Time at which Message was created
        /// </summary>
        public readonly long TimeStamp;
        /// <summary>
        /// Base Description of Message
        /// </summary>
        public readonly string BaseDescription;
        
        public readonly string Method;
        public readonly int Monitor;
        public readonly bool IsShowMsg;
        public readonly long FoldType;
        public readonly long HostFoldType;
        public readonly long PriorityScore;
        public readonly string LogId;
        public readonly string MsgProcessFilterK;
        public readonly string MsgProcessFilterV;
        public readonly string FromIdc;
        public readonly string ToIdc;
        public readonly IReadOnlyList<string> FilterMsgTags;
        public readonly LiveMessageSEI SEI;
        public readonly LiveMessageID DependRootId;
        public readonly LiveMessageID DependId;
        public readonly long HostPriorityScore;
        public readonly long RoomMessageHeatLevel;
        public readonly long FoldTypeForWeb;
        public readonly long HostFoldTypeForWeb;
        public readonly long ClientSendTime;
        public readonly IMDispatchStrategy DispatchStrategy;
        
        protected AMessageData(Header header)
        {
            RoomId = header?.RoomId ?? -1;
            MessageId = header?.MsgId ?? -1;
            TimeStamp = header?.CreateTime ?? -1;
            BaseDescription = header?.Describe ?? string.Empty;
            Method = header?.Method ?? string.Empty;
            Monitor = header?.Monitor ?? -1;
            IsShowMsg = header?.IsShowMsg ?? false;
            FoldType = header?.FoldType ?? -1;
            HostFoldType = header?.AnchorFoldType ?? -1;
            PriorityScore = header?.PriorityScore ?? -1;
            LogId = header?.LogId ?? string.Empty;
            MsgProcessFilterK = header?.MsgProcessFilterK ?? string.Empty;
            MsgProcessFilterV = header?.MsgProcessFilterV ?? string.Empty;
            FromIdc = header?.FromIdc ?? string.Empty;
            ToIdc = header?.ToIdc ?? string.Empty;
            FilterMsgTags = header?.FilterMsgTagsList?.Count > 0 ? new List<string>(header.FilterMsgTagsList).AsReadOnly() : new List<string>(0).AsReadOnly();
            SEI = header?.SEI;
            DependRootId = header?.DependRootId;
            DependId = header?.DependId;
            HostPriorityScore = header?.AnchorPriorityScore ?? -1;
            RoomMessageHeatLevel = header?.RoomMessageHeatLevel ?? -1;
            FoldTypeForWeb = header?.FoldTypeForWeb ?? -1;
            HostFoldTypeForWeb = header?.AnchorFoldTypeForWeb ?? -1;
            ClientSendTime = header?.ClientSendTime ?? -1;
            DispatchStrategy = header?.DispatchStrategy != null ? (IMDispatchStrategy)header.DispatchStrategy : IMDispatchStrategy.Default;
        }
    }
}
