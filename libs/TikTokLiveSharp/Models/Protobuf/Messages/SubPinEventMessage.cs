using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class SubPinEventMessage : AProtoBase
    {
        [ProtoContract]
        [System.Serializable]
        public enum ActionType
        {
            Unknown = 0,
            Pin = 1,
            Unpin = 2
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ActionType Action_Type { get; }
        
        [ProtoMember(3)]
        public SubPinCard Card { get; }

        [ProtoMember(4)]
        public long OperatorUserId { get; }
    }
}
