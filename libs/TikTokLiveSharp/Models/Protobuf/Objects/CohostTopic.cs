using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CohostTopic : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string TitleKey { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string TitleText { get; } = string.Empty;

        [ProtoMember(21)]
        public bool Liked { get; }

        [ProtoMember(22)]
        public long TotalHeat { get; }

        [ProtoMember(23)]
        public long TotalRivals { get; }

        [ProtoMember(24)]
        public List<Image> RivalsAvatarList { get; } = new List<Image>();
    }
}
