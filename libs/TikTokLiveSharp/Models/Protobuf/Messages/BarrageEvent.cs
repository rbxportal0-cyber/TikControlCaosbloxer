using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BarrageEvent : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string EventName { get; } = string.Empty;

        [ProtoMember(2)]
        public Dictionary<string, string> ParamsMap { get; } = new Dictionary<string, string>();
    }
}
