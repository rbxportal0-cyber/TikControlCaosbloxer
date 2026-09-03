using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class VoteResponseData : AProtoBase
    {
        [ProtoMember(1)]
        public List<PollOptionInfo> OptionList { get; } = new List<PollOptionInfo>();

        [ProtoMember(2)]
        public bool CommentBanned { get; }
    }
}
