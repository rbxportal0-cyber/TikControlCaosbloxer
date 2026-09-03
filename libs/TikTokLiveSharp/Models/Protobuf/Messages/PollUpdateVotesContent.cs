using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollUpdateVotesContent : AProtoBase
    {
        [ProtoMember(2)]
        public List<PollOptionInfo> OptionList { get; }
    }
}
