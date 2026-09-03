using System.Collections.Generic;
using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class Ranking : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; } = string.Empty;

        [ProtoMember(3)]
        public Text Text { get; }

        [ProtoMember(4)]
        public List<ValueLabel> Details { get; } = new List<ValueLabel>();
    }
}
