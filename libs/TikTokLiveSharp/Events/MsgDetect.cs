namespace TikTokLiveSharp.Events
{
    public sealed class MsgDetect : AMessageData
    {
        #region InnerTypes
        public sealed class TimeInfo
        {
            public readonly long ClientStartMs;
            public readonly long ApiRecvTimeMs;
            public readonly long ApiSendToGoimMs;

            private TimeInfo(Models.Protobuf.Messages.MsgDetectMessage.TimeInfo timeInfo)
            {
                ClientStartMs = timeInfo?.ClientStartMs ?? -1;
                ApiRecvTimeMs = timeInfo?.ApiRecvTimeMs ?? -1;
                ApiSendToGoimMs = timeInfo?.ApiSendToGoimMs ?? -1;
            }

            public static implicit operator TimeInfo(Models.Protobuf.Messages.MsgDetectMessage.TimeInfo timeInfo) => new TimeInfo(timeInfo);
        }
        
        public sealed class TriggerCondition
        {
            public readonly bool UplinkDetectHttp;
            public readonly bool UplinkDetectWebSocket;
            public readonly bool DetectP2PMsg;
            public readonly bool DetectRoomMsg;
            public readonly bool HttpOptimize;

            private TriggerCondition(Models.Protobuf.Messages.MsgDetectMessage.TriggerCondition triggerCondition)
            {
                UplinkDetectHttp = triggerCondition?.UplinkDetectHttp ?? false;
                UplinkDetectWebSocket = triggerCondition?.UplinkDetectWebSocket ?? false;
                DetectP2PMsg = triggerCondition?.DetectP2PMsg ?? false;
                DetectRoomMsg = triggerCondition?.DetectRoomMsg ?? false;
                HttpOptimize = triggerCondition?.HttpOptimize ?? false;
            }

            public static implicit operator TriggerCondition(Models.Protobuf.Messages.MsgDetectMessage.TriggerCondition triggerCondition) => new TriggerCondition(triggerCondition);
        }
        #endregion

        public readonly int DetectType;
        public readonly TriggerCondition Trigger_Condition;
        public readonly TimeInfo Time_Info;
        public readonly int TriggerBy;
        public readonly string FromRegion;

        internal MsgDetect(Models.Protobuf.Messages.MsgDetectMessage msg)
            : base(msg?.Header)
        {
            DetectType = msg?.DetectType ?? -1;
            Trigger_Condition = msg?.Trigger_Condition;
            Time_Info = msg?.Time_Info;
            TriggerBy = msg?.TriggerBy ?? -1;
            FromRegion = msg?.FromRegion ?? string.Empty;
        }
    }
}