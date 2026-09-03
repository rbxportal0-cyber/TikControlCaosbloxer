using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// <para>
    /// Known as "Common" in TikTok's code
    /// </para>
    /// </summary>
    [ProtoContract]
    public partial class Header : AProtoBase
    {
        /// <summary>
        /// "Method" that created the message (Usually 'Webcast'+MessageType)
        /// </summary>
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Method { get; } = string.Empty;

        [ProtoMember(2)]
        public long MsgId { get; }

        [ProtoMember(3)]
        public long RoomId { get; }

        [ProtoMember(4)]
        public long CreateTime { get; }

        [ProtoMember(5)]
        public int Monitor { get; }

        [ProtoMember(6)]
        public bool IsShowMsg { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Describe { get; } = string.Empty;

        [ProtoMember(8)]
        public Text DisplayText { get; }

        [ProtoMember(9)]
        public long FoldType { get; }

        [ProtoMember(10)]
        public long AnchorFoldType { get; }

        [ProtoMember(11)]
        public long PriorityScore { get; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string LogId { get; } = string.Empty;

        [ProtoMember(13)]
        [DefaultValue("")]
        public string MsgProcessFilterK { get; } = string.Empty;

        [ProtoMember(14)]
        [DefaultValue("")]
        public string MsgProcessFilterV { get; } = string.Empty;

        [ProtoMember(15)]
        [DefaultValue("")]
        public string FromIdc { get; } = string.Empty;

        [ProtoMember(16)]
        [DefaultValue("")]
        public string ToIdc { get; } = string.Empty;
        
        [ProtoMember(17)]
        public List<string> FilterMsgTagsList { get; } = new List<string>();
        
        [ProtoMember(18)]
        public LiveMessageSEI SEI { get; }

        [ProtoMember(19)]
        public LiveMessageID DependRootId { get; }

        [ProtoMember(20)]
        public LiveMessageID DependId { get; }

        [ProtoMember(21)]
        public long AnchorPriorityScore { get; }

        [ProtoMember(22)]
        public long RoomMessageHeatLevel { get; }

        [ProtoMember(23)]
        public long FoldTypeForWeb { get; }

        [ProtoMember(24)]
        public long AnchorFoldTypeForWeb { get; }

        [ProtoMember(25)]
        public long ClientSendTime { get; }

        [ProtoMember(26)]
        public IMDispatchStrategy DispatchStrategy { get; }
    }
}
