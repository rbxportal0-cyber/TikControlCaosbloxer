using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LokiContent : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string GiftType { get; } = string.Empty;

        [ProtoMember(2)]
        public long GiftDuration { get; }

        [ProtoMember(3)]
        public bool NeedScreenShot { get; }

        [ProtoMember(4)]
        public bool ShouldMultiFrame { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string ViewOverlay { get; } = string.Empty;

        [ProtoMember(6)]
        public BefViewRenderSize BefViewRenderSize { get; }

        [ProtoMember(7)]
        public int BefViewRenderFps { get; }

        [ProtoMember(8)]
        public int BefViewFitMode { get; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string ModelNames { get; } = string.Empty;

        [ProtoMember(10)] 
        public List<string> RequirementsList { get; } = new List<string>();
    }
}
