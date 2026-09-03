using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class ValueLabel : AProtoBase
    {
        [ProtoMember(1)]
        public int Data1 { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label2 { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Label3 { get; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Label4 { get; }
    }
}
