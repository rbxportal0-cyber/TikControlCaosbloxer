using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    /// <summary>
    /// Links to Image-Files on the TikTok-CDN
    /// </summary>
    [ProtoContract]
    public partial class Image : AProtoBase
    {
        [ProtoContract]
        public partial class Content : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Name { get; } = string.Empty;

            [ProtoMember(2)]
            [DefaultValue("")]
            public string FontColor { get; } = string.Empty;

            [ProtoMember(3)]
            public long Level { get; }
        }

        /// <summary>
        /// Usually has 3 different urls with different sizes/extensions
        /// </summary>
        [ProtoMember(1)]
        public List<string> Urls { get; } = new List<string>();

        /// <summary>
        /// uri
        /// </summary>
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Uri { get; } = string.Empty;

        [ProtoMember(3)]
        public long Height { get; }

        [ProtoMember(4)]
        public long Width { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string AvgColor { get; } = string.Empty;

        [ProtoMember(6)]
        public int ImageType { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string OpenWebUrl { get; } = string.Empty;

        [ProtoMember(8)]
        public Content ImageContent { get; }

        [ProtoMember(9)]
        public bool IsAnimated { get; }
    }
}
