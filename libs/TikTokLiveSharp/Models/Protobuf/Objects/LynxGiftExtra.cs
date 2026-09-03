using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LynxGiftExtra : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public long Code { get; }

        [ProtoMember(3)]
        public long Type { get; }

        [ProtoMember(4)]
        public List<string> ParamsList { get; } = new List<string>();

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Extra { get; } = string.Empty;
    }
}
