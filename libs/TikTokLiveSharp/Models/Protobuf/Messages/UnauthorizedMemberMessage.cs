using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class UnauthorizedMemberMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public int Action { get; }

        [ProtoMember(3)]
        public Text NickNamePrefix { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string NickName { get; } = string.Empty;

        [ProtoMember(5)]
        public Text EnterText { get; }
    }
}
