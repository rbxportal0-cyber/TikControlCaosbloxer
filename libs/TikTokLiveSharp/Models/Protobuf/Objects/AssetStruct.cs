using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AssetStruct : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Name { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ResourceUri { get; } = string.Empty;

        [ProtoMember(3)]
        public long LegacyEffectId { get; }

        [ProtoMember(4)]
        public Image ResourceUrl { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Describe { get; } = string.Empty;

        [ProtoMember(6)]
        public long Id { get; }

        [ProtoMember(7)]
        public int ResourceType { get; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Md5 { get; } = string.Empty;

        [ProtoMember(9)]
        public long Size { get; }

        [ProtoMember(10)]
        public LokiContent LokiContent { get; }

        [ProtoMember(26)]
        public int DownloadType { get; }

        [ProtoMember(27)] 
        public List<string> ModelRequirementsList { get; } = new List<string>();

        [ProtoMember(28)]
        public Image ResourceByteVc1Url { get; }

        [ProtoMember(29)]
        [DefaultValue("")]
        public string ByteVc1Md5 { get; } = string.Empty;

        [ProtoMember(30)] 
        public List<VideoResource> VideoResourceList { get; } = new List<VideoResource>();

        [ProtoMember(31)]
        public FaceRecognitionArchiveMeta FaceRecognitionArchiveMeta { get; }

        [ProtoMember(32)]
        [DefaultValue("")]
        public string LynxUrlSettingsKey { get; } = string.Empty;

        [ProtoMember(33)]
        public int DowngradeResourceType { get; }
    }
}
