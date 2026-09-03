using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftsInBox : AProtoBase
    {
        [ProtoMember(1)] 
        public List<GiftInfoInBox> GiftsInfoInBoxList { get; } = new List<GiftInfoInBox>();
    }
}
