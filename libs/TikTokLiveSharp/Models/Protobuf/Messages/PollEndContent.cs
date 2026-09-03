using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PollEndContent : AProtoBase
    {
        [ProtoMember(1)]
        public int EndType { get; } // Possibly an Enum?

        [ProtoMember(2)]
        public List<PollOptionInfo> OptionList { get; }

        [ProtoMember(3)]
        public User Operator { get; }
    }
}
