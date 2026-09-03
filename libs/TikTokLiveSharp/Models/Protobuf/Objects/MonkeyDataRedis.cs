using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class MonkeyDataRedis : AProtoBase
    {
        [ProtoMember(1)]
        public long Deprecated1 { get; }

        [ProtoMember(2)]
        public long Deprecated2 { get; }

        [ProtoMember(3)]
        public long Deprecated3 { get; }

        [ProtoMember(4)]
        public long Deprecated4 { get; }

        [ProtoMember(5)]
        public long Deprecated5 { get; }

        [ProtoMember(6)]
        public long Deprecated6 { get; }

        [ProtoMember(7)]
        public long Deprecated7 { get; }

        [ProtoMember(8)]
        public long Deprecated8 { get; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string Deprecated9 { get; } = string.Empty;
    }
}
