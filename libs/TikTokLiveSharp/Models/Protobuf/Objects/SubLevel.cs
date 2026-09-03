using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubLevel : AProtoBase
    {
        [ProtoMember(1)]
        public int Level { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Desc { get; } = string.Empty;

        [ProtoMember(3)]
        public int MonthLimit { get; }

        [ProtoMember(4)]
        public LevelBadge Badge { get; }

        [ProtoMember(5)]
        public BadgeStruct BadgeStruct { get; }
    }
}
