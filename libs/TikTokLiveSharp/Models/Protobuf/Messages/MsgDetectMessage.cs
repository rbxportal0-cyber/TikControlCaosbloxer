using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class MsgDetectMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class TimeInfo : AProtoBase
        {
            [ProtoMember(1)]
            public long ClientStartMs { get; }

            [ProtoMember(2)]
            public long ApiRecvTimeMs { get; }

            [ProtoMember(3)]
            public long ApiSendToGoimMs { get; }
        }

        [ProtoContract]
        public partial class TriggerCondition : AProtoBase
        {
            [ProtoMember(1)]
            public bool UplinkDetectHttp { get; }

            [ProtoMember(2)]
            public bool UplinkDetectWebSocket { get; }

            [ProtoMember(3)]
            public bool DetectP2PMsg { get; }

            [ProtoMember(4)]
            public bool DetectRoomMsg { get; }

            [ProtoMember(5)]
            public bool HttpOptimize { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public int DetectType { get; } // Possibly an Enum?

        [ProtoMember(3)]
        public TriggerCondition Trigger_Condition { get; }

        [ProtoMember(4)]
        public TimeInfo Time_Info { get; }

        [ProtoMember(5)]
        public int TriggerBy { get; } // Possibly an Enum?

        [ProtoMember(6)]
        [DefaultValue("")]
        public string FromRegion { get; } = string.Empty;
    }
}
