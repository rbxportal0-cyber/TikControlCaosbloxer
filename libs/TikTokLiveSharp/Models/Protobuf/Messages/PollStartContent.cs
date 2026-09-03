using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollStartContent : AProtoBase
    {
        [ProtoMember(1)]
        public long StartTime { get; }

        [ProtoMember(2)]
        public long EndTime { get; }

        [ProtoMember(3)]
        public List<PollOptionInfo> OptionList { get; } = new List<PollOptionInfo>();

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(5)]
        public User Operator { get; }
    }
}
