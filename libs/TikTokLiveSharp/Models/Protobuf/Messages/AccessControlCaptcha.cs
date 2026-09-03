using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class AccessControlCaptcha : AProtoBase
    {
        [ProtoMember(1)] 
        public long CaptchaRecordId { get; }

        [ProtoMember(2)]
        public long RoomId { get; }

        [ProtoMember(3)]
        public long VerifyDurationInSec { get; }
    }
}
