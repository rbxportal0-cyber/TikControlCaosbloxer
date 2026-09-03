using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkLayerListUser : AProtoBase
    {
        [ProtoMember(1)]
        public Player User { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LinkmicId { get; } = string.Empty;

        [ProtoMember(3)]
        public Position Pos { get; }

        [ProtoMember(4)]
        public long LinkedTimeNano { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string AppVersion { get; }
    }
}
