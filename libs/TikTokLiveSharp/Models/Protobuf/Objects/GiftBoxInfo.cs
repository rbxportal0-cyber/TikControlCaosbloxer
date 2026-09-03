using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftBoxInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long Capacity { get; }

        [ProtoMember(2)]
        public bool IsPrimaryBox { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string SchemeUrl { get; } = string.Empty;

        [ProtoMember(4)] 
        public List<GiftInfoInBox> GiftInfosInBoxList { get; } = new List<GiftInfoInBox>();
    }
}
