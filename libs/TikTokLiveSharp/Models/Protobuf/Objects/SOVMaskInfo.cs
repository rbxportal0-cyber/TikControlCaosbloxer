using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SOVMaskInfo : AProtoBase
    {
        [ProtoMember(1)]
        public SOVMaskInfoType Type { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;
    }
}
