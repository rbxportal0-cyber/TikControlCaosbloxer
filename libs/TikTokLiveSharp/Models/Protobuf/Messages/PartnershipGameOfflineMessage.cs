using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PartnershipGameOfflineMessage : AProtoBase
    {
        [ProtoContract]
        public partial class OfflineGameInfo : AProtoBase
        {
            [System.Serializable]
            public enum OfflineType
            {
                TaskOffline = 0,
                EventOffline = 1,
                DropsOffline = 2
            }

            [ProtoMember(1)]
            [DefaultValue("")]
            public string TaskId { get; } = string.Empty;

            [ProtoMember(2)]
            [DefaultValue("")]
            public string ToastText { get; } = string.Empty;

            [ProtoMember(3)]
            public int TaskListLen { get; }

            [ProtoMember(4)]
            public OfflineType Offline_Type { get; }
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public List<OfflineGameInfo> OfflineGameList { get; } = new List<OfflineGameInfo>();
    }
}
