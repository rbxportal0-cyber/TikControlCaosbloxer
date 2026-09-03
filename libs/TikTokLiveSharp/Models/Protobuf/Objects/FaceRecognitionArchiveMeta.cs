using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class FaceRecognitionArchiveMeta : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Version { get; } = string.Empty;

        [ProtoMember(2)]
        public List<string> RequirementsList { get; } = new List<string>();

        [ProtoMember(3)]
        [DefaultValue("")]
        public string ModelNames { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string SdkExtra { get; } = string.Empty;
    }
}
