using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollingResponse : AProtoBase
    {
        [ProtoContract]
        public partial class Extra : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Cursor { get; } = string.Empty;

            [ProtoMember(2)]
            public long FetchInterval { get; }

            [ProtoMember(3)]
            public long Now { get; }
        }

        [ProtoMember(1)]
        public List<string> DataList { get; } = new List<string>();

        [ProtoMember(2)]
        public Extra ExtraData { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string InternalExt { get; } = string.Empty;

        [ProtoMember(4)]
        public int StatusCode { get; }
    }
}
