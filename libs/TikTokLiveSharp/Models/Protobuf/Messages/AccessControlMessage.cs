using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class AccessControlMessage : AProtoBase
    {
        public enum MsgContentCase
        {
            Msg_Content_Not_Set = 0,
            Captcha = 2
        }

        public MsgContentCase MsgContent => (MsgContentCase)oneofMsgContentCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofMsgContentCase;

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public AccessControlCaptcha Captcha
        {
            get => oneofMsgContentCase.Is(2) ? (AccessControlCaptcha)oneofMsgContentCase.Object : default;
            private set => oneofMsgContentCase = new DiscriminatedUnion64Object(2, value);
        }
    }
}
