using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class FlexImageStruct : AProtoBase
    {
        [ProtoMember(1)]
        public List<string> UrlList { get; } = new List<string>();

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Uri { get; } = string.Empty;

        [ProtoMember(3)]
        public List<long> FlexSettingList { get; } = new List<long>();
    }
}
