using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class SubPinEvent : AMessageData
    {
        [System.Serializable]
        public enum ActionType
        {
            Unknown = 0,
            Pin = 1,
            Unpin = 2
        }
        
        public readonly ActionType Action_Type;
        public readonly SubPinCard Card;
        public readonly long OperatorUserId;

        internal SubPinEvent(Models.Protobuf.Messages.SubPinEventMessage msg)
            : base(msg?.Header)
        {
            Action_Type = msg?.Action_Type != null ? (ActionType)msg.Action_Type : ActionType.Unknown;
            Card = msg?.Card;
            OperatorUserId = msg?.OperatorUserId ?? -1;
        }
    }
}