using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollOptionInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long Votes { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string DisplayContent { get; } = string.Empty;

        [ProtoMember(3)]
        public int OptionIdx { get; }

        [ProtoMember(4)]
        public List<VoteUser> VoteUserList { get; } = new List<VoteUser>();
    }
}
