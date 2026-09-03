using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Generic
{
    [ProtoContract]
    public partial class DynamicMessage : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; set; } = string.Empty;
        
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Type { get; set; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string KeyField { get; set; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string TypeField { get; set; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Psm { get; set; } = string.Empty;

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Handler { get; set; } = string.Empty;

        [ProtoMember(7)]
        [DefaultValue("")]
        public string ContentEncoding { get; set; } = string.Empty;

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Serializer { get; set; } = string.Empty;
    }
}
