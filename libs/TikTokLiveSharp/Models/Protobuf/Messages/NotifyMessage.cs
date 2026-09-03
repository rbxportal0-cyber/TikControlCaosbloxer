using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class NotifyMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class Background : AProtoBase
        {
            [ProtoMember(1)]
            public int Width { get; }

            [ProtoMember(2)]
            public int Height { get; }

            [ProtoMember(3)]
            public List<string> UrlList { get; } = new List<string>();

            [ProtoMember(4)]
            [DefaultValue("")]
            public string Uri { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class Content : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string ContentStr { get; } = string.Empty;

            [ProtoMember(2)]
            public bool NeedHighLight { get; }
        }

        [ProtoContract]
        public partial class ContentList : AProtoBase
        {
            [ProtoMember(1)]
            public List<Content> ContentsList { get; } = new List<Content>();

            [ProtoMember(2)]
            [DefaultValue("")]
            public string HighLightColor { get; } = string.Empty;
        }

        [ProtoContract]
        public partial class Extra : AProtoBase
        {
            [ProtoMember(1)]
            public long Duration { get; }

            [ProtoMember(2)]
            public Background Background { get; }

            [ProtoMember(3)]
            public ContentList ContentList { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Schema { get; } = string.Empty;

        [ProtoMember(3)]
        public long NotifyType { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string ContentStr { get; } = string.Empty;

        [ProtoMember(5)]
        public User User { get; }

        [ProtoMember(6)]
        public Extra ExtraData { get; }

        [ProtoMember(7)]
        public long NotifyClass { get; }

        [ProtoMember(8)]
        public List<long> FlexSettingList { get; } = new List<long>();

        [ProtoMember(9)]
        [DefaultValue("")]
        public string Source { get; } = string.Empty;

        [ProtoMember(10)]
        public long FromUserId { get; }

        [ProtoMember(11)]
        public PrivilegeLogExtra PrivilegeLogExtra { get; }

        [ProtoMember(12)]
        public long ToAnchorId { get; }
    }
}
