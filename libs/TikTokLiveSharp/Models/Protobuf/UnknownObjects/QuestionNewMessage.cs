using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class QuestionNewMessage : AProtoBase
    {
        [ProtoContract]
        public partial class QuestionDetails : AProtoBase
        {
            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Text { get; } = string.Empty;

            [ProtoMember(4)]
            public ulong Timestamp { get; }

            [ProtoMember(5)]
            public User User { get; }

            [ProtoMember(20)]
            public uint Data20 { get; }
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public QuestionDetails Data2 { get; }
    }
}
