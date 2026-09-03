using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class EventCard : AProtoBase
    {
        [ProtoMember(1)]
        public LiveEventInfo Event { get; }

        [ProtoMember(2)]
        public long CardStartTime { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string CardIconUrl { get; } = string.Empty;
    }
}
